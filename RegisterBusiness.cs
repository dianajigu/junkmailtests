using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework; 

[TestFixture]
public class RegisterBusiness
{
    public IWebDriver _driver;

    public RegisterBusiness()
    {
        _driver = new FirefoxDriver();
        _driver.Url = "http://junkmail2.dsdemo.co.za/";
        System.Threading.Thread.Sleep(5000);
    }

    [Test, Order(1)]
    public void RegisterBusinessTest()
    {
        //cant test further because of captcha
        _driver.FindElement(By.LinkText("Register")).Click();
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.LinkText("Business")).Click();
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.XPath("(//input[@id='Email'])[2]")).SendKeys("diana@yahoo.com");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.XPath("(//input[@id='Password'])[2]")).SendKeys("1234567");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.XPath("(//input[@id='ConfirmPassword'])[2]")).SendKeys("1234567");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Id("BusinessName")).SendKeys("mutavara");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Id("FirstName")).SendKeys("Diana");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Id("LastName")).SendKeys("Jigu");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.XPath("(//button[@type='button'])[4]")).Click();
        _driver.Close();
    }

    [Test, Order(4)]
    public void ExitTest()
    {
        _driver.Close();
    }
}
