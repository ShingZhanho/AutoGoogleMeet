using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoGoogleMeet.UI.HelpCentre;

namespace AutoGoogleMeet.UI.SetupUI {
    public partial class frmSetupGAccount : TemplateSetupForm {
        public frmSetupGAccount() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            new frmHelpCentre(HelpDocs.GetPageUri(HelpDocs.HelpModules.Setup, "EmailDomainRestrictions"))
                .ShowDialog();
        }
    }
}
