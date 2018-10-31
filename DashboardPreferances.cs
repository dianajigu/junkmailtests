using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

[TestFixture]
public class DashboardPreferences
{

    private IWebDriver _driver;

    public DashboardPreferences()
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
    public void ActivatePreferances()
    {
        _driver.Navigate().GoToUrl("https://accounts.junkmail.co.za/preferences");

        _driver.FindElement(By.Id("User_PreferenceDisplayAdCounter")).Click();
        _driver.FindElement(By.Id("User_PreferenceDontSendEmailNotification")).Click();
        _driver.FindElement(By.Id("User_PreferenceLockContactDetails")).Click();
        _driver.FindElement(By.Id("User_PreferenceAutoPopulateAdFields")).Click();
        _driver.FindElement(By.XPath("//input[@value='Save Preferences']")).Click();

        Assert.AreEqual(null, _driver.FindElement(By.Id("User_PreferenceDisplayAdCounter")).GetAttribute("checked"));
        Assert.AreEqual(null, _driver.FindElement(By.Id("User_PreferenceDontSendEmailNotification")).GetAttribute("checked"));
        Assert.AreEqual(null, _driver.FindElement(By.Id("User_PreferenceLockContactDetails")).GetAttribute("checked"));
        Assert.AreEqual(null, _driver.FindElement(By.Id("User_PreferenceAutoPopulateAdFields")).GetAttribute("checked"));
    }

    [Test, Order(3)]
    public void DeactivatePreferances()
    { 
        _driver.FindElement(By.Id("User_PreferenceDisplayAdCounter")).Click();
        _driver.FindElement(By.Id("User_PreferenceDontSendEmailNotification")).Click();
        _driver.FindElement(By.Id("User_PreferenceLockContactDetails")).Click();
        _driver.FindElement(By.Id("User_PreferenceAutoPopulateAdFields")).Click();
        _driver.FindElement(By.XPath("//input[@value='Save Preferences']")).Click();

        Assert.AreEqual("true", _driver.FindElement(By.Id("User_PreferenceDisplayAdCounter")).GetAttribute("checked"));
        Assert.AreEqual("true", _driver.FindElement(By.Id("User_PreferenceDontSendEmailNotification")).GetAttribute("checked"));
        Assert.AreEqual("true", _driver.FindElement(By.Id("User_PreferenceLockContactDetails")).GetAttribute("checked"));
        Assert.AreEqual("true", _driver.FindElement(By.Id("User_PreferenceAutoPopulateAdFields")).GetAttribute("checked"));

        _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Preferences'])[4]/following::i[1]")).Click();
    }
}

