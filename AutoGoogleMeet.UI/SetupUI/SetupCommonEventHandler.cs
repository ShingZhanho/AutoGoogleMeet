using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace AutoGoogleMeet.UI.SetupUI {
    public static class SetupCommonEventHandler {
        public static void CancelButton_OnClick(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "設定尚未完成，如你現在離開，程式將不會對你的電腦進行變更。你是否確定要離開？",
                "Auto Google Meet 設定精靈",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        /// <summary>
        /// This method is used for deleting all installed components after user's cancellation
        /// </summary>
        public static void TidyUpAndExit(string installDir) {
            MessageBox.Show(
                "設定精靈將會還原所有變更，完成後會自動關閉。",
                "Auto Google Meet 設定精靈",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            var bgwDelete = new BackgroundWorker() {
                WorkerReportsProgress = false,
                WorkerSupportsCancellation = false
            };
            bgwDelete.DoWork += BackgroundDelete_DoWork;
            bgwDelete.RunWorkerCompleted += BackgroundDelete_WorkComplete;
            var args = new List<object> {installDir};
            bgwDelete.RunWorkerAsync(args);
        }

        private static void BackgroundDelete_DoWork(object sender, DoWorkEventArgs e) {
            // Deletes all files and settings here
            var args = (List<object>) e.Argument;
            // Deletes installation files
            try {
                Directory.Delete(args[0].ToString(), true);
            }
            catch {
                // ignored
            }
            
            // Delete startup settings
        }

        private static void BackgroundDelete_WorkComplete(object sender, RunWorkerCompletedEventArgs e) {
            Application.Exit();
        }
    }
}