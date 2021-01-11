using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AutoGoogleMeet.Settings;
using AutoGoogleMeet.WebDrv;

namespace AutoGoogleMeet.UI.SetupUI {
    public partial class frmSetupWelcome : Form {
        public frmSetupWelcome() {
            InitializeComponent();
            // Add shield
            AddShieldToButton(btnNext);

            // set dynamic content
            lblVersion.Text = Constants.Version;
            btnCancel.Click += new EventHandler(SetupCommonEventHandler.CancelButton_OnClick);
        }

        #region Code for adding shield icon to button

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
            uint Msg, int wParam, int lParam);

        // Make the button display the UAC shield.
        public static void AddShieldToButton(Button btn)
        {
            const Int32 BCM_SETSHIELD = 0x160C;

            // Give the button the flat style and make it
            // display the UAC shield.
            btn.FlatStyle = FlatStyle.System;
            SendMessage(btn.Handle, BCM_SETSHIELD, 0, 1);
        }

        #endregion

        private static bool IsAdministrator() {
            try {
                Directory.CreateDirectory(
                    $"{Environment.SystemDirectory}\\AutoGoogleMeetTestFolder");
                Directory.Delete($"{Environment.SystemDirectory}\\AutoGoogleMeetTestFolder");
            }
            catch (UnauthorizedAccessException) {
                // Not running as admin
                return false;
            }
            return true;
        }

        private void btnNext_Click(object sender, EventArgs e) {
            // Check network connection
            if (!NetworkUtil.NetworkIsConnected()) {
                MessageBox.Show(
                    "無法開始設定。你的電腦尚未連接到網際網路，應用程式需要網際網路來運作。",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            if (!IsAdministrator()) {
                MessageBox.Show(
                    "錯誤 (0x00000001)\n無法開始設定，將會以系統管理員身份重新開啟設定精靈。",
                    "Auto Google Meet 設定精靈",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                // Restart
                new Process {
                    StartInfo = new ProcessStartInfo {
                        UseShellExecute = true,
                        FileName = Application.ExecutablePath,
                        Verb = "runas"
                    }
                }.Start();
                Application.Exit();
                return;
            }

            // show User agreement UI
            new frmUserAgreement().Show();
            Close();
        }
    }
}