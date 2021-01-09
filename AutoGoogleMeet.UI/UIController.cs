using System;
using System.IO;
using System.Windows.Forms;
using AutoGoogleMeet.Settings;
using System.Xml.Schema;
using AutoGoogleMeet.UI.SetupUI;

namespace AutoGoogleMeet.UI {
    public static class UIController {
        [STAThread]
        public static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // show Setup form if not done
            if (!SetupIsCompleted()) new frmSetupWelcome().Show();
            Application.Run();
        }

        private static bool SetupIsCompleted() {
            if (!File.Exists($@"{Constants.ExePath}\UserData\{Constants.Version}\userconfig.json"))
                return false;
            var uc = new UserConfiguration($@"{Constants.ExePath}\UserData\{Constants.Version}\userconfig.json");
            return uc.Status == 0 && uc.AppManifest.SetupCompleted;
        }
    }
}