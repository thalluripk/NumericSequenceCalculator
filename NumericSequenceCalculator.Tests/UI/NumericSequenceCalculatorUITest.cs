using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace NumericSequenceCalculator.Tests.UI
{
    /// <summary>
    /// UI Functional testing with Selenium Web Driver
    /// </summary>
    [TestClass]
    public class NumericSequenceCalculatorUITest
    {
        [TestMethod]
        public void TestUINumberSequence()
        {
            var driver = WebDriverLocator.GetWebDriver();
            driver.Navigate();

            driver.ImplicitWait(10);

            var elmText = driver.FindElementById("Num");
            elmText.Click();
            elmText.SendKeys("10");
            
            var btnCalculate = driver.FindElementById("calculate");
            btnCalculate.Submit();

            driver.ImplicitWait(10);

            // Validate results
            var elm = driver.FindElementById("Number Sequence");
            var result = elm.Text;
            driver.Quit();

            Assert.AreEqual<string>("1 2 3 4 5 6 7 8 9 10", result);
        }

        [TestMethod]
        public void TestUIOddNumberSequence()
        {
            var driver = WebDriverLocator.GetWebDriver();
            driver.Navigate();

            driver.ImplicitWait(10);

            var elmText = driver.FindElementById("Num");
            elmText.Click();
            elmText.SendKeys("10");

            var btnCalculate = driver.FindElementById("calculate");
            btnCalculate.Submit();

            driver.ImplicitWait(10);

            // Validate results
            var elm = driver.FindElementById("Odd Number Sequence");
            var result = elm.Text;
            driver.Quit();

            Assert.AreEqual<string>("1 3 5 7 9 10", result);
        }

        [TestMethod]
        public void TestUIEvenNumberSequence()
        {
            var driver = WebDriverLocator.GetWebDriver();
            driver.Navigate();

            driver.ImplicitWait(10);

            var elmText = driver.FindElementById("Num");
            elmText.Click();
            elmText.SendKeys("10");

            var btnCalculate = driver.FindElementById("calculate");
            btnCalculate.Submit();

            driver.ImplicitWait(10);

            // Validate results
            var elm = driver.FindElementById("Even Number Sequence");
            var result = elm.Text;
            driver.Quit();

            Assert.AreEqual<string>("2 4 6 8 10", result);
        }

        [TestMethod]
        public void TestUIEncodedSequence()
        {
            var driver = WebDriverLocator.GetWebDriver();
            driver.Navigate();

            driver.ImplicitWait(10);

            var elmText = driver.FindElementById("Num");
            elmText.Click();
            elmText.SendKeys("10");

            var btnCalculate = driver.FindElementById("calculate");
            btnCalculate.Submit();

            driver.ImplicitWait(10);

            // Validate results
            var elm = driver.FindElementById("Encoded Sequence");
            var result = elm.Text;
            driver.Quit();

            Assert.AreEqual<string>("1 2 C 4 E C 7 8 C E", result);
        }

        [TestMethod]
        public void TestUIFibonacciSequence()
        {
            var driver = WebDriverLocator.GetWebDriver();
            driver.Navigate();

            driver.ImplicitWait(10);

            var elmText = driver.FindElementById("Num");
            elmText.Click();
            elmText.SendKeys("10");

            var btnCalculate = driver.FindElementById("calculate");
            btnCalculate.Submit();

            driver.ImplicitWait(10);

            // Validate results
            var elm = driver.FindElementById("Fibonacci Sequence");
            var result = elm.Text;
            driver.Quit();

            Assert.AreEqual<string>("1 2 3 5 8 10", result);
        }
    }
}
