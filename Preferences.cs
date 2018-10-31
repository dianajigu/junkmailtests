using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

[TestFixture]
public class Preferences
{

    private IWebDriver _driver;

    public Preferences()
    {
        _driver = new FirefoxDriver();
        _driver.Url = "http://junkmail.co.za/login";
        System.Threading.Thread.Sleep(5000);
    }


    [Test, Order(1)]
    public void Login()
    {
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Name("Email")).SendKeys("diana@dotslash.co.za");
        _driver.FindElement(By.Name("Password")).SendKeys("1234567");
        _driver.FindElement(By.Id("btnLogin")).Click();
        System.Threading.Thread.Sleep(5000);
    }

    [Test, Order(2)]
    public void checkAll()
    {
        _driver.Navigate().GoToUrl("https://accounts.junkmail.co.za/profile");
        _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Preferences'])[1]/following::div[2]")).Click();
        _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Business Page'])[2]/following::a[1]")).Click();
        _driver.FindElement(By.Id("User_PreferenceDisplayAdCounter")).Click();
        _driver.FindElement(By.Id("User_PreferenceDontSendEmailNotification")).Click();
        _driver.FindElement(By.Id("User_PreferenceDontSendEmailNotification")).Click();
        _driver.FindElement(By.Id("User_PreferenceLockContactDetails")).Click();
        _driver.FindElement(By.Id("User_PreferenceAutoPopulateAdFields")).Click();
        _driver.FindElement(By.Id("User_PreferenceAutoPopulateAdFields")).Click();
        _driver.FindElement(By.XPath("//input[@value='Save Preferences']")).Click();
        _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Preferences'])[4]/following::i[1]")).Click();
        _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Preferences'])[4]/following::i[1]")).Click();
        _driver.FindElement(By.Id("User_PreferenceDisplayAdCounter")).Click();
        _driver.FindElement(By.Id("User_PreferenceDontSendEmailNotification")).Click();
        _driver.FindElement(By.Id("User_PreferenceLockContactDetails")).Click();
        _driver.FindElement(By.Id("User_PreferenceAutoPopulateAdFields")).Click();
        _driver.FindElement(By.XPath("//input[@value='Save Preferences']")).Click();
        Assert.AreEqual("on", _driver.FindElement(By.Id("User_PreferenceDisplayAdCounter")).GetAttribute("value"));
        Assert.AreEqual("on", _driver.FindElement(By.Id("User_PreferenceDontSendEmailNotification")).GetAttribute("value"));
        Assert.AreEqual("on", _driver.FindElement(By.Id("User_PreferenceLockContactDetails")).GetAttribute("value"));
        Assert.AreEqual("on", _driver.FindElement(By.Id("User_PreferenceAutoPopulateAdFields")).GetAttribute("value"));
        _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Preferences'])[4]/following::i[1]")).Click();
    }
}

