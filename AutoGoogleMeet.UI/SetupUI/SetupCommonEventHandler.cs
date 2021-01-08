using System;
using System.Windows.Forms;

namespace AutoGoogleMeet.UI.SetupUI {
    public static class SetupCommonEventHandler {
        public static void CancelButton_OnClick(object sender, EventArgs e) {
            var result = MessageBox.Show(
                "設定尚未完成，你是否要離開？",
                "警告",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}