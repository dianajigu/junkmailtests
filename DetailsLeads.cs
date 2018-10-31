using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

    [TestFixture]
    public class DetailsLeads
    {
        private IWebDriver driver;
    //      private string baseURL;

        public DetailsLeads()
        {
            driver = new FirefoxDriver();
            System.Threading.Thread.Sleep(5000);
        }


    [Test, Order(1)]
    public void TheUntitledTestCaseTest()
    {
        //respond
        driver.Navigate().GoToUrl("https://www.junkmail.co.za/property/residential-properties/gauteng/pretoria/pretoria-east/2-bedroom-flat-available-in-garsfontein/5d25e5bc52294ebf8dfb3c2371156f58");
        driver.FindElement(By.Id("Name")).SendKeys("diana");
        driver.FindElement(By.Id("Phone")).SendKeys("0774441111");
        driver.FindElement(By.Id("Email")).SendKeys("autotest@yahoo.com");
        driver.FindElement(By.Id("btnSubmitLead")).Click();
        //login
        driver.Navigate().GoToUrl("https://www.junkmail.co.za/login");
        System.Threading.Thread.Sleep(5000);
        driver.FindElement(By.Name("Email")).SendKeys("diana@dotslash.co.za");
        driver.FindElement(By.Name("Password")).SendKeys("1234567");
        driver.FindElement(By.Id("btnLogin")).Click();
    }

    [Test, Order(2)]
    public void deleteAds()
    {
        //confirm and delete
        driver.Navigate().GoToUrl("https://accounts.junkmail.co.za/messages/general");
        driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Date Received'])[1]/following::td[3]")).Click();
        
        Assert.AreEqual("2 bedroom flat available in Garsfontein", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Date Received'])[1]/following::td[3]")).Text);
        driver.Navigate().Refresh();
        driver.FindElement(By.CssSelector("[class='btn btn-danger btn-flat btn-sm']")).Click();
        }

    }

