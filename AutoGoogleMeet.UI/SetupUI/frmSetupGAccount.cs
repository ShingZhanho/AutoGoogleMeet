using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoGoogleMeet.UI.HelpCentre;
using AutoGoogleMeet.WebDrv;

namespace AutoGoogleMeet.UI.SetupUI {
    public partial class frmSetupGAccount : TemplateSetupForm {
        public frmSetupGAccount() {
            InitializeComponent();
            
            // Debug code
            var webDrv = new SeleniumControl(new SeleniumOptions {RunInBackground = false});
            webDrv.Run();
        }

        private void button1_Click(object sender, EventArgs e) {
            new frmHelpCentre(HelpDocs.GetPageUri(HelpDocs.HelpModules.Setup, "EmailDomainRestrictions"))
                .ShowDialog();
        }
    }
}
