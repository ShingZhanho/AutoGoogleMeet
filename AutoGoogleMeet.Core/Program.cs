using System;
using AutoGoogleMeet.UI;

namespace AutoGoogleMeet.Core {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            UIController.Main(args);
        }
    }
}