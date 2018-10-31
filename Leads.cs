using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;

[TestFixture]
class Leads
    {

    public IWebDriver _driver;



    public Leads()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("disable-infobars");
        options.AddArguments("--start-maximized");
        _driver = new ChromeDriver(options);
        System.Threading.Thread.Sleep(5000);

    }

    [Test, Order(1)]
    public void AllLeads()
    {
        _driver.Navigate().GoToUrl("https://accounts.junkmail.co.za/messages/general");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Name("Username")).SendKeys("junkmaildev@gmail.com");
        _driver.FindElement(By.Name("Password")).SendKeys("Tmp@@123");
        _driver.FindElement(By.CssSelector("[class='btn btn-primary btn-block']")).Click();
        _driver.FindElement(By.XPath("//body[@id='amAcc']/div/div/div/div[2]/div/div/a/i")).Click();
        _driver.FindElement(By.XPath("//div[@id='inbox']/table/tbody/tr/td[3]")).Click();
        System.Threading.Thread.Sleep(5000);
        String advertTitle = _driver.FindElement(By.XPath("//div[@id='inbox']/table/tbody/tr/td[3]")).Text;
        System.Threading.Thread.Sleep(5000);
        String leadadTitle = _driver.FindElement(By.LinkText(advertTitle)).Text;
        _driver.FindElement(By.XPath("//div[@id='inbox']/table/thead/tr/th[3]")).Click();
        String emailadress = _driver.FindElement(By.XPath("//div[@id='inbox']/table/tbody/tr/td[5]")).Text;
        Assert.AreEqual(emailadress, _driver.FindElement(By.XPath("//body[@id='amAcc']/div[2]/div[2]/div[3]/div/div/div/div[2]/div/div/div/a[2]/span")).Text);
        _driver.FindElement(By.LinkText("Close")).Click();
        _driver.FindElement(By.XPath("(//input[@type='checkbox'])[2]")).Click();
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Id("deleteAll")).Click();
        _driver.FindElement(By.XPath("(//button[@type='button'])[5]")).Click();
        _driver.Navigate().Refresh();
        System.Threading.Thread.Sleep(10000);
        Console.WriteLine("test");
    }

    [Test, Order(2)]
    public void EmailLeads()
    {

        
    }

    [Test, Order(3)]
    public void ExitTest()
    {
        _driver.Close();
    }



}
