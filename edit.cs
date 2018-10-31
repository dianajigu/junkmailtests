using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver _driver;

        public void SeleniumTests()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AddArgument("disable-infobars");
            options.AddArguments("--start-maximized");
            _driver = new FirefoxDriver(options);
            _driver.Url = "http://junkmail.co.za/login";
            //        _driver.Url = "http://junkmail.dsdemo.co.za/login";
            System.Threading.Thread.Sleep(5000);
        }


        [Test]
        public void TheUntitledTestCaseTest()
        {
            _driver.Navigate().GoToUrl("https://www.junkmail.co.za/");
            _driver.FindElement(By.Id("top")).Click();
            _driver.FindElement(By.LinkText("Login")).Click();
            _driver.FindElement(By.Id("Email")).Clear();
            _driver.FindElement(By.Id("Email")).SendKeys("junkmaildev@gmail.com");
            _driver.FindElement(By.Id("Password")).Clear();
            _driver.FindElement(By.Id("Password")).SendKeys("Tmp@@123");
            _driver.FindElement(By.Id("btnLogin")).Click();
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='My Services'])[1]/following::a[1]")).Click();
            _driver.FindElement(By.LinkText("My Ads")).Click();
            _driver.FindElement(By.LinkText("Inactive Ads30")).Click();
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='power_settings_new'])[2]/following::i[1]")).Click();
            _driver.FindElement(By.Id("post-advert")).Click();
        }


 
    }

