using System;
using AutoGoogleMeet.UI;

namespace AutoGoogleMeet.Core {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            UIController.Main(null);
        }
    }
}