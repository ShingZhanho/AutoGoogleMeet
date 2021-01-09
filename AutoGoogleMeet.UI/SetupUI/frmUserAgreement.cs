using System;
using System.IO;
using System.Windows.Forms;
using AutoGoogleMeet.Settings;
using AutoGoogleMeet.UI.SetupUI;

public partial class frmUserAgreement : TemplateSetupForm {
	public frmUserAgreement() : base() {
		InitializeComponent();

		// Load user agreement
        try {
            rtfUA.LoadFile($"{Constants.ExePath}\\Resources\\Setup\\UserAgreement_zh-HK.rtf");
        } catch {
            rtfUA.Text = "無法載入使用者條款，檔案可能損毁或丟失。\r\r" +
                         "如你按下「下一步」，仍表示你同意使用條款。";
        }
    }
}
