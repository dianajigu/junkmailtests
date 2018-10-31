using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

[TestFixture]
class HomePage
{
    public IWebDriver _driver;

    public HomePage()
    {
        _driver = new FirefoxDriver();
        _driver.Url = "http://junkmail2.dsdemo.co.za/";
        System.Threading.Thread.Sleep(5000);
    }

    [Test, Order(1)]
    public void HomePageTests()
    {
        _driver.FindElement(By.CssSelector("[class='navbar-brand']")).Click();
        _driver.FindElement(By.CssSelector("[class='btn btn-block btn-link m-t']")).Click();
        Assert.AreEqual("All Ads on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        _driver.Navigate().Back();

        _driver.FindElement(By.LinkText("View all Pets")).Click();
        Assert.AreEqual("Pets on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        _driver.Navigate().Back();

        _driver.FindElement(By.LinkText("View all Jobs on Junk Mail")).Click();
        Assert.AreEqual("Jobs on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        _driver.Navigate().Back();

        _driver.FindElement(By.XPath("(//a[contains(text(),'Cars')])[3]")).Click();
        Assert.AreEqual("Cars on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        _driver.Navigate().Back();

        _driver.FindElement(By.LinkText("Houses to Rent")).Click();
        Assert.AreEqual("Houses For Rent on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        _driver.Navigate().Back();

        _driver.FindElement(By.LinkText("Classic Cars, Bikes and Custom Builds")).Click();
        Assert.AreEqual("Classic Cars, Bikes and Custom Built on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        _driver.Navigate().Back();


        _driver.FindElement(By.XPath("(//a[contains(text(),'Truck Spares and Parts')])[2]")).Click();
        Assert.AreEqual("Truck Spares and Parts on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        _driver.Navigate().Back();

        _driver.FindElement(By.LinkText("Houses to Rent")).Click();
        Assert.AreEqual("Houses For Rent on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        _driver.Navigate().Back();


        _driver.FindElement(By.XPath("(//a[contains(text(),'Computers and Gaming')])[2]")).Click();
        Assert.AreEqual("Computers and Gaming on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        _driver.Navigate().Back();

        _driver.FindElement(By.LinkText("Furniture")).Click();
        Assert.AreEqual("Furniture on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        _driver.Navigate().Back();

        _driver.FindElement(By.XPath("(//a[contains(text(),'Computers and Gaming')])[2]")).Click();
        Assert.AreEqual("Computers and Gaming on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        _driver.Navigate().Back();

        _driver.FindElement(By.XPath("(//a[contains(text(),'Truck Spares and Parts')])[2]")).Click();
        Assert.AreEqual("Truck Spares and Parts on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        _driver.Navigate().Back();


        _driver.FindElement(By.LinkText("Wanted")).Click();
        Assert.AreEqual("All Ads Wanted on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        _driver.Navigate().Back();

        _driver.FindElement(By.LinkText("To Swop")).Click();
        Assert.AreEqual("All Ads To Swop on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        _driver.Navigate().Back();

        _driver.FindElement(By.LinkText("Give Away")).Click();
        Assert.AreEqual("All Ads Give Away on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        _driver.Navigate().Back();

        _driver.FindElement(By.LinkText("For Rent")).Click();
        Assert.AreEqual("All Ads For Rent on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        _driver.Navigate().Back();

    }

}

