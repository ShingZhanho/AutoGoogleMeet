using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGoogleMeet.UI.HelpCentre {
    public partial class frmHelpCentre : Form {
        public frmHelpCentre(Uri helpPageUri) {
            InitializeComponent();
            pageViewer.Url = helpPageUri;
        }
    }
}
