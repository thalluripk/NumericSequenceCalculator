using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSequenceCalculator.Tests.UI
{
    /// <summary>
    /// This class loads the WebDriver according to the configuation.
    /// NOTE: This code is tested only for Chrome browser. Please ensure that ChromeDriver.exe file is copied to bin/debug folder before test this.
    /// </summary>
    internal class WebDriverLocator
    {
        public static RemoteWebDriver GetWebDriver()
        {
            RemoteWebDriver webDriver = null;

            var browser = ConfigurationManager.AppSettings["Browser"];
            switch (browser)
            {
                case "Chrome":
                    webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();
                    break;

                case "IE":
                    webDriver = new OpenQA.Selenium.IE.InternetExplorerDriver();
                    break;

                case "Edge":
                    webDriver = new OpenQA.Selenium.Edge.EdgeDriver();
                    break;

                case "FireFox":
                    webDriver = new OpenQA.Selenium.Firefox.FirefoxDriver();
                    break;
            }

            if (webDriver != null)
                webDriver.Url = ConfigurationManager.AppSettings["AppUrl"];

            return webDriver;
        }
    }
}
