using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoGoogleMeet.Settings;

namespace AutoGoogleMeet.UI.HelpCentre {
    internal static class HelpDocs {
        internal static Uri GetPageUri(HelpModules modules, string docFileName) {
            var path = Path.Combine(PagesDir, modules.ToString(), $"{docFileName}.html");
            return new Uri(path);
        }

        private static readonly string PagesDir = $"{Application.StartupPath}\\Resources\\HelpDocs";

        internal enum HelpModules {
            Setup
        }
    }
}
