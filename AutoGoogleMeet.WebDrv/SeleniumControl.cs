using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AutoGoogleMeet.Settings;

// WebDrv Module is used for interact with Selenium
namespace AutoGoogleMeet.WebDrv
{
    public class SeleniumControl {
        public SeleniumControl(SeleniumOptions options) {
            Options = options;
            SeleniumObject = new ChromeDriver(Constants.ChromeDrvPath);
        }

        public readonly IWebDriver SeleniumObject;
        public SeleniumOptions Options { get; }

        public void Run() {
            SeleniumObject.Navigate().GoToUrl("https://account.google.com/");
        }
    }

    public class SeleniumOptions {
        public bool RunInBackground { get; set; }
    }
}
