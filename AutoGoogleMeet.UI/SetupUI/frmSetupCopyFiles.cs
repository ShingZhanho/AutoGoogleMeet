using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AutoGoogleMeet.UI.SetupUI {
    public partial class frmSetupCopyFiles : TemplateSetupForm {
        public frmSetupCopyFiles() {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            // Replace cancel button event handlers
            btnCancel.Click -= SetupCommonEventHandler.CancelButton_OnClick;
            btnCancel.Click += this.ButtonCancel_OnClick;
        }
        private BackgroundWorker _bgw;

        public void frmSetupCopyFiles_Load(object sender, EventArgs e) {
            var copyUtil = new SetupFileCopier(lblCurrentOperation, pgBar);
            btnNext.Enabled = false;

            // install in background
            _bgw = new BackgroundWorker() {
                WorkerReportsProgress = false,
                WorkerSupportsCancellation = true
            };
            _bgw.DoWork += bgw_DoWork;
            _bgw.RunWorkerCompleted += bgw_Completed;
            _bgw.RunWorkerAsync(copyUtil);
        }

        #region Background worker methods

        private void bgw_DoWork(object sender, DoWorkEventArgs e) {
            var copyUtil = e.Argument as SetupFileCopier;
            var installDir = Path.Combine(
                Path.GetPathRoot(Environment.SystemDirectory),
                "AutoGoogleMeet");

            // code for debug, uncomment to test cancel function
            Thread.Sleep(5000);

            if (!Directory.Exists(installDir)) {
                copyUtil.CreateDir(installDir);
            } else {
                // Warning of deletion
                var dResults = MessageBox.Show(
                    "一個Auto Google Meet已經在本機上完成設定，繼續進行會刪除原有的設定。如果你要更新到新版，請使用內置的更新工具。\n" +
                    "你是否要繼續？", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dResults == DialogResult.Yes) {
                    // Delete all existing files
                    var attempt = 0;
                    while (attempt < 5) { // Try for at most 5 times
                        if (e.Cancel) { // Canceled
                            Application.Exit(); // Leave without tidying up
                        }
                        attempt += 1;
                        try {
                            copyUtil.UpdateUIManually("正在嘗試刪除舊版...");
                            Directory.Delete(installDir, true);
                        } catch {
                            // If delete failed, kill the running process then delete again
                            try {
                                foreach (var proc in Process.GetProcessesByName("AutoGoogleMeet")) {
                                    copyUtil.UpdateUIManually("失敗，正在嘗試停止舊版，然後重試...");
                                    if (proc.Id == Process.GetCurrentProcess().Id) continue;
                                    proc.Kill(); // kill running process
                                    break;
                                }
                            } catch {
                                // ignored
                            }
                            // fails for 5 times, end installation and exit
                            if (attempt == 5) {
                                MessageBox.Show("無法刪除舊版的Auto Google Meet，設定精靈將會結束。",
                                    "Auto Google Meet 設定精靈",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                // The application will not be able to clean up under this circumstance
                                // Exit automatically
                                Application.Exit();
                            }
                            continue;
                        }
                        break;
                    }
                    copyUtil.CreateDir(installDir);
                } else {
                    // Exit if the user cancel
                    SetupCommonEventHandler.TidyUpAndExit(installDir);
                }
            }
            copyUtil.CopyAll(Application.StartupPath, installDir,
                new Random().Next(0, 5) * 1000);
            
            // Register to launch with Windows
            try {
                var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                key?.SetValue("AutoGoogleMeet", Path.Combine(installDir, "AutoGoogleMeet.exe"));
                key?.Close();
            }
            catch {
                // ignored
            }
        }

        private void bgw_Completed(object sender, RunWorkerCompletedEventArgs e) {
            if (e.Cancelled) {
                // Tidy up and exit
                SetupCommonEventHandler.TidyUpAndExit(Path.Combine(Path.GetPathRoot(Environment.SystemDirectory), "AutoGoogleMeet"));
            }

            // Update UI
            lblCurrentOperation.Text = "完成";
            pgBar.Value = pgBar.Maximum;
            btnNext.Enabled = true;
        }

        #endregion

        // Custom event handler for cancel button
        private void ButtonCancel_OnClick(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "設定尚未完成，如你現在離開，程式將不會對你的電腦進行變更。你是否確定要離開？",
                "Auto Google Meet 設定精靈",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                SetupCommonEventHandler.TidyUpAndExit(Path.Combine(Path.GetPathRoot(Environment.SystemDirectory),
                    "AutoGoogleMeet"));
        }

        private void btnNext_Click(object sender, EventArgs e) {
            // Restart the copied app in X:\AutoGoogleMeet
            new Process {
                StartInfo = new ProcessStartInfo {
                    UseShellExecute = true,
                    Verb = "runas",
                    FileName = Path.Combine(
                        Path.GetPathRoot(Environment.SystemDirectory), 
                        "AutoGoogleMeet\\AutoGoogleMeet.exe"),
                    Arguments = "--SetupJumpToForm:3"
                }
            }.Start();
            Application.Exit();
        }
    }

    public class SetupFileCopier {
        public SetupFileCopier(Label labelOutput, ProgressBar bar) {
            _outputLabel = labelOutput;
            _bar = bar;
            _bar.Maximum = 300;
        }

        private readonly Label _outputLabel;
        private readonly ProgressBar _bar;

        public void CreateDir(string dirPath) {
            _outputLabel.Text = $"正在建立資料夾：{dirPath}";
            Directory.CreateDirectory(dirPath);
            if (_bar.Value + 2 < _bar.Maximum) _bar.Value += 2;
        }

        public void CopyFile(string fromPath, string destinationPath) {
            _outputLabel.Text = $"正在複製檔案：{destinationPath}";
            File.Copy(fromPath, destinationPath);
            if (_bar.Value + 2 < _bar.Maximum) _bar.Value += 2;
        }

        public void UpdateUIManually(string text, int progress = -1) {
            _outputLabel.Text = text;
            if (progress >= _bar.Minimum && progress <= _bar.Maximum) _bar.Value = progress;
        }

        public void CopyAll(string fromDir, string destinationDir, int delay = 0) {
            if (destinationDir.EndsWith("\\")) destinationDir = destinationDir.Substring(0, destinationDir.Length - 1);
            // Create all directories
            foreach (var dir in Directory.GetDirectories(fromDir)) {
                CreateDir($@"{destinationDir}{dir.Replace(fromDir, string.Empty)}");
                Thread.Sleep(delay); // delay for dedicated time
                CopyAll(dir,
                    Path.Combine(destinationDir, dir.Replace(fromDir, string.Empty).Remove(0,1)));
            }
            
            // Copy files to destination
            foreach (var file in Directory.GetFiles(fromDir)) {
                CopyFile(file,
                    Path.Combine(destinationDir,
                        file.Replace(fromDir,
                                string.Empty)
                            .Remove(0,1)));
                Thread.Sleep(delay);
            }
        }

    }
}
