using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSequenceCalculator.Tests.UI
{
    /// <summary>
    /// Selenium Web driver extension methods
    /// </summary>
    public static class WebDriverExtensionMethods
    {
        public static void ImplicitWait(this RemoteWebDriver driver, int sec)
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(sec));
        }
    }
}
