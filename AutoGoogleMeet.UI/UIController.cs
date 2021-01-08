using System;
using System.Windows.Forms;
using System.Xml.Schema;

namespace AutoGoogleMeet.UI {
    public static class UIController {
        [STAThread]
        public static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }
    }
}