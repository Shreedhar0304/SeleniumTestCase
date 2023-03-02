using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            try
            {
                int waitingTime = 3000;
                By SigninButton = By.XPath("//a[@class='btn btn-primary']");
                By AzureButton = By.XPath("//button[@class='btn btn-primary btn-line']");
                By Signin = By.XPath("//div/small[contains(text(), 'microsoft.com')]");

                IWebDriver webDriver = new EdgeDriver();

                Thread.Sleep(waitingTime);

                webDriver.Navigate().GoToUrl("https://ftqtysbdevfeedbackportal.powerappsportals.com/welcomefasttrack/");

                Thread.Sleep(waitingTime);

                webDriver.Manage().Window.Maximize();

                Thread.Sleep(waitingTime);

                webDriver.FindElement(SigninButton).Click();

                Thread.Sleep(waitingTime);

                webDriver.FindElement(AzureButton).Click();

                Thread.Sleep(waitingTime);

                webDriver.FindElement(Signin).Click();
                Thread.Sleep(waitingTime);

                webDriver.Quit();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
