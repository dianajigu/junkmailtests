using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

[TestFixture]
public class AccounType
{
    private IWebDriver driver;

    public AccounType()
    {
        driver = new FirefoxDriver();
        System.Threading.Thread.Sleep(5000);
    }

    [Test, Order(1)]
    public void OwnerAcc()
    {
        driver.Navigate().GoToUrl("https://www.junkmail.co.za/login");
        System.Threading.Thread.Sleep(5000);
        driver.FindElement(By.Id("Email")).SendKeys("dianajigu@gmail.com");
        driver.FindElement(By.Id("Password")).SendKeys("1234567");
        driver.FindElement(By.Id("btnLogin")).Click();
        System.Threading.Thread.Sleep(10000);  
        driver.FindElement(By.CssSelector("[class='other x']")).Click();
    }

    [Test, Order(2)]
    public void BusinessAcc()
    {
        driver.Navigate().GoToUrl("https://www.junkmail.co.za/login");
        driver.FindElement(By.Id("Email")).SendKeys("diana@dotslash.co.za");
        driver.FindElement(By.Id("Password")).SendKeys("1234567");
        driver.FindElement(By.Id("btnLogin")).Click();
        Assert.AreEqual("Business Account", driver.FindElement(By.CssSelector("[class='label label-primary']")).Text);
        driver.Navigate().GoToUrl("https://accounts.junkmail.co.za/premiumupgrade");
        Assert.AreEqual("Premium Upgrade", driver.FindElement(By.CssSelector("[class='container-fluid text-center']")).Text);      
        driver.FindElement(By.CssSelector("[class='other x']")).Click();
    }

    [Test, Order(3)]
    public void PremiumAcc()
    {
        driver.Navigate().GoToUrl("https://www.junkmail.co.za/login");
        driver.FindElement(By.Id("Email")).SendKeys("junkmaildev@gmail.com");
        driver.FindElement(By.Id("Password")).SendKeys("Tmp@@123");
        driver.FindElement(By.Id("btnLogin")).Click();
        driver.FindElement(By.CssSelector("[class='premium']"));
        driver.FindElement(By.Id("mychart"));
        driver.FindElement(By.CssSelector("[class='other x']")).Click();
    }
 
}
