using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;


[TestFixture]
class RegisterOwner
{

    public IWebDriver _driver;

    public RegisterOwner()
    {
        _driver = new FirefoxDriver();
        _driver.Url = "http://junkmail2.dsdemo.co.za/";
        System.Threading.Thread.Sleep(5000);
    }

    [Test, Order(1)]
    public void RegisterOwnerTest()
    {
        //recaptcha issues
        _driver.Navigate().GoToUrl("http://junkmail2.dsdemo.co.za/register");
        _driver.FindElement(By.LinkText("Register")).Click();

        _driver.FindElement(By.Id("Email")).SendKeys("free@yahoo.com");
        _driver.FindElement(By.Id("Password")).SendKeys("1234567");
        _driver.FindElement(By.Id("ConfirmPassword")).SendKeys("1234567");
        _driver.FindElement(By.Id("submit-register")).Click();
    }

    [Test, Order(2)]
    public void ExitTest()
    {
        _driver.Close();
    }
}
