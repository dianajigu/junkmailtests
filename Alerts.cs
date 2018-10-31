using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

[TestFixture]
public class Alerts
 {
        private IWebDriver driver;

        public Alerts()
        {
            driver = new FirefoxDriver();
            System.Threading.Thread.Sleep(5000);
        }

    [Test, Order(1)]
    public void Createalert()
    {
        driver.Navigate().GoToUrl("https://www.junkmail.co.za/baby-and-kids/clothes-and-shoes/baby-shoes/gauteng/pretoria/for-sale");
        driver.FindElement(By.Id("Email")).SendKeys("diana@dotslash.co.za");
        driver.FindElement(By.CssSelector("[class='btn btn-warning btn-block ']")).Click();

        driver.Navigate().GoToUrl("https://www.junkmail.co.za/login");
        driver.FindElement(By.Name("Email")).SendKeys("diana@dotslash.co.za");
        driver.FindElement(By.Name("Password")).SendKeys("1234567");
        driver.FindElement(By.Id("btnLogin")).Click();
        System.Threading.Thread.Sleep(5000);
    }

    [Test, Order(2)]
    public void ActivateAlert()
    {
        driver.Navigate().GoToUrl("https://www.junkmail.co.za/my-alerts");
        System.Threading.Thread.Sleep(5000);

        Assert.AreEqual("Baby and Kids", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='For Sale'])[1]/following::span[1]")).Text);
        Assert.AreEqual("Clothes and Shoes", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Baby and Kids'])[2]/following::span[1]")).Text);
        Assert.AreEqual("Baby Shoes", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Clothes and Shoes'])[1]/following::span[1]")).Text);
        Assert.AreEqual("Gauteng", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Baby Shoes'])[1]/following::span[1]")).Text);
        Assert.AreEqual("Pretoria", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Gauteng'])[2]/following::span[1]")).Text);

        driver.FindElement(By.CssSelector("[class='btn btn-default btn-sm btnActivate']")).Click();
        var myalert = driver.SwitchTo().Alert();
        myalert.Accept();
    }

    [Test, Order(3)]
    public void DactivateAlert() {

        System.Threading.Thread.Sleep(5000);
        driver.FindElement(By.CssSelector("[class='btn btn-default btn-sm btnDeactivate']")).Click();
        var myalert2 = driver.SwitchTo().Alert();
        myalert2.Accept();
    }

    [Test, Order(4)]
    public void DeleteAlert() {

        System.Threading.Thread.Sleep(5000); 
        driver.FindElement(By.CssSelector("[class='btn btn-danger btn-sm btnDelete']")).Click();
        var myalert3 = driver.SwitchTo().Alert();
        myalert3.Accept();
        System.Threading.Thread.Sleep(5000);
    }   
    
    [Test, Order(5)]
    public void KeywordSearch()
    { 
        System.Threading.Thread.Sleep(5000);
        driver.Navigate().GoToUrl("https://www.junkmail.co.za/q-keywordsearch%20alert");
        driver.FindElement(By.Id("Email")).SendKeys("diana@dotslash.co.za");
        driver.FindElement(By.CssSelector("[class='btn btn-warning btn-block ']")).Click();
        System.Threading.Thread.Sleep(5000);
        driver.Navigate().GoToUrl("https://www.junkmail.co.za/my-alerts");
        System.Threading.Thread.Sleep(5000);

        Assert.AreEqual("keywordsearch alert", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='My Alerts'])[3]/following::span[1]")).Text);

        driver.FindElement(By.CssSelector("[class='btn btn-danger btn-sm btnDelete']")).Click();
        var myalert4 = driver.SwitchTo().Alert();
        myalert4.Accept();
    }
}
