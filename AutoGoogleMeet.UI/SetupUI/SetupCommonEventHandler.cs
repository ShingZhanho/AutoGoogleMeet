using System;
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
    }
}