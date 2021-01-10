using System;
using System.Collections.Generic;
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
            var cmdOptions = new CommandLineOptions(args);
            // show Setup form if not done
            if (!SetupIsCompleted()) {
                // Show the dedicated form
                switch (cmdOptions.JumpToForm) {
                    case CommandLineOptions.SetupJumpToForm.WelcomeForm:
                        new frmSetupWelcome().Show();
                        break;
                    case CommandLineOptions.SetupJumpToForm.UAForm:
                        new frmUserAgreement().Show();
                        break;
                    case CommandLineOptions.SetupJumpToForm.CopyFilesForm:
                        new frmSetupCopyFiles().Show();
                        break;
                    case CommandLineOptions.SetupJumpToForm.MeetIDsForm:
                        break;
                }
            }
            Application.Run();
        }

        private static bool SetupIsCompleted() {
            if (!File.Exists($@"{Constants.ExePath}\UserData\{Constants.Version}\userconfig.json"))
                return false;
            var uc = new UserConfiguration($@"{Constants.ExePath}\UserData\{Constants.Version}\userconfig.json");
            return uc.Status == 0 && uc.AppManifest.SetupCompleted;
        }
    }
    
    internal class CommandLineOptions {
        internal CommandLineOptions(string[] args) {
            if (args is null) return;
            foreach (var arg in args) {
                var (command, paras) = ExtractOption(arg);
                switch (command) {
                    case "SetupJumpToForm":
                        Set_SetupJumpToForm(paras);
                        break;
                }
            }
        }
        
        // Options
        internal SetupJumpToForm JumpToForm = SetupJumpToForm.WelcomeForm;
        
        
        // Methods
        private (string command, object[] paras) ExtractOption(string option) {
            if (option.Split(':').Length == 0) return (option.Replace("--", string.Empty), null);
            var commandHead = option.Split(':')[0].Replace("--", string.Empty);
            var commandPara = new List<object>();
            foreach (var str in option.Split(':')[1].Split(';')) {
                if (int.TryParse(str, out _)) {
                    commandPara.Add(int.Parse(str));
                    continue;
                }
                commandPara.Add(str);
            }
            return (commandHead, commandPara.ToArray());
        }

        private void Set_SetupJumpToForm(IReadOnlyList<object> paras) {
            for (var i = paras.Count; i --> 0;) {
                if (!int.TryParse(paras[i].ToString(), out var num)) continue;
                JumpToForm = (SetupJumpToForm) num;
                return;
            }
        }

        internal enum SetupJumpToForm {
            WelcomeForm = 0,
            UAForm = 1, 
            CopyFilesForm = 2, 
            MeetIDsForm = 3
        }
    }
}