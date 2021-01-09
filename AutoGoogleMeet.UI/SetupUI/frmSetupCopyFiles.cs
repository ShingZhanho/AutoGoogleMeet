using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGoogleMeet.UI.SetupUI {
    public partial class frmSetupCopyFiles : TemplateSetupForm {
        public frmSetupCopyFiles() {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public void frmSetupCopyFiles_Load(object sender, EventArgs e) {
            var copyUtil = new SetupFileCopier(lblCurrentOperation, pgBar);
            var installDir = Path.Combine(
                Path.GetPathRoot(Environment.SystemDirectory),
                "AutoGoogleMeet");
            if (!Directory.Exists(installDir)) {
                copyUtil.CreateDir(installDir);
            } else {
                // Warning of deletion
                var dResults = MessageBox.Show(
                    "一個Auto Google Meet已經在本機上完成設定，繼續進行會刪除原有的設定。如果你要更新到新版，請使用內置的更新工具。\n" +
                    "你是否要繼續？", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dResults == DialogResult.Yes) {
                    // Delete all existing files
                    var attempt = 0;
                    while (attempt < 5) {
                        attempt += 1;
                        try {
                            Directory.Delete(installDir, true);
                        } catch {
                            try {
                                foreach (var proc in Process.GetProcessesByName("AutoGoogleMeet")) {
                                    if (proc.Id == Process.GetCurrentProcess().Id) continue;
                                    proc.Kill();
                                }
                            } catch {
                                // ignored
                            }
                            continue;
                        }
                        break;
                    }
                    copyUtil.CreateDir(installDir);
                } else {
                    // Exit if the user cancel
                    Application.Exit();
                }
            }
            copyUtil.CopyAll(Application.StartupPath, installDir);
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
