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
            rtfUA.Text = "�o���d��ʹ���ߗl��n�����ܓp�ٻ�Gʧ��\r\r" +
                         "���㰴�¡���һ�������Ա�ʾ��ͬ��ʹ�×l�";
        }
    }
}
