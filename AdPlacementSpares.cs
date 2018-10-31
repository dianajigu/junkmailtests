using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;

[TestFixture]
class AdPlacementSpares
{
    public IWebDriver _driver;

    public AdPlacementSpares()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("disable-infobars");
        options.AddArguments("--start-maximized");
        _driver = new ChromeDriver(options);
        _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);
    }

    [Test, Order(1)]
    public void SparesAds()
    {
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("categoryName"))).SelectByText("Spares");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("CategoryId"))).SelectByText("Machinery Spares and Parts");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Tyres");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("Smooth Treads");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("MakeId"))).SelectByText("ADE");
        new SelectElement(_driver.FindElement(By.Id("Condition"))).SelectByText("New");
        new SelectElement(_driver.FindElement(By.Id("Intention"))).SelectByText("For Sale");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Id("Price")).SendKeys("200000");
        _driver.FindElement(By.Id("Title")).SendKeys("Rim straightening machine");
        _driver.FindElement(By.Id("Description")).SendKeys("Single phase rim straightening machine (balansmatic) hardly used in very good condition.");
        new SelectElement(_driver.FindElement(By.Id("regionId"))).SelectByText("Limpopo");
        new SelectElement(_driver.FindElement(By.Id("cityId"))).SelectByText("Other");
        _driver.FindElement(By.Id("Email")).SendKeys("dianajig5u@gmail.com");
        _driver.FindElement(By.Id("post-advert")).Click();
        System.Threading.Thread.Sleep(5000);
        Assert.AreEqual("Your ad has been placed successfully.", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);
    }

    [Test, Order(2)]
    public void ExitTest()
    {
        _driver.Close();
    }

}

