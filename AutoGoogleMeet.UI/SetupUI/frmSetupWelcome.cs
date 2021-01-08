using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoGoogleMeet.UI.SetupUI {
    public partial class frmSetupWelcome : Form {
        public frmSetupWelcome() {
            InitializeComponent();
            // Add shield
            AddShieldToButton(btnNext);
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
                    $"{Path.GetPathRoot(Environment.SystemDirectory)}AutoGoogleMeetTestFolder");
                Directory.Delete($"{Path.GetPathRoot(Environment.SystemDirectory)}AutoGoogleMeetTestFolder");
            }
            catch (UnauthorizedAccessException e) {
                // Not running as admin
                return false;
            }
            return true;
        }
    }
}