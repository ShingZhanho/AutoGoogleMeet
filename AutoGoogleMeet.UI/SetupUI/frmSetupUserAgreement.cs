using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AutoGoogleMeet.Settings;

namespace AutoGoogleMeet.UI.SetupUI {
    public partial class frmSetupUserAgreement : Form {
        public frmSetupUserAgreement() {
            InitializeComponent();

            // set dynamic content
            btnCancel.Click += new EventHandler(SetupCommonEventHandler.CancelButton_OnClick);
            lblVersion.Text = Constants.Version;
        }

        private void btnNext_Click(object sender, EventArgs e) {
            
        }
    }
}