using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;

[TestFixture]
class Searchbar
{
    public IWebDriver _driver;
    String searchWord = "nissan juke";
    String searchRegion = "Gauteng";
    String searchCat = "Cars";


    public Searchbar()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("disable-infobars");
        options.AddArguments("--start-maximized");
        _driver = new ChromeDriver(options);
        _driver.Url = "http://junkmail.co.za/";
        System.Threading.Thread.Sleep(5000);
    }


    [Test, Order(1)]
    public void checkAdsonPage()
    {
        var numberofads = _driver.FindElements(By.CssSelector("[class='search-result']")).Count;
        if (numberofads < 20)
        {
            Console.WriteLine("Alert!! Did not return adequate number of ads");
            _driver.Quit();
        }
    }

    [Test, Order(2)]
    public void SearchKeyword() {
        _driver.FindElement(By.CssSelector("[class='navbar-brand']")).Click();

        // 1 keyword
        _driver.FindElement(By.CssSelector("[class ='form-control']")).SendKeys(searchWord);
        _driver.FindElement(By.XPath("//body[@id='top']/nav")).Click();
        _driver.FindElement(By.XPath("//a[@id='btnClick']/span")).Click();
        Assert.AreEqual('"' + searchWord + '"' + " in All Ads on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        Assert.AreEqual("nissan juke in All Ads in South Africa | Junk Mail", _driver.Title);
        checkAdsonPage();
    }

    [Test, Order(3)]
    public void SearchCategory() {
        //2 category
        _driver.FindElement(By.Id("sRegion")).Click();
        _driver.FindElement(By.LinkText("South Africa")).Click();
        _driver.FindElement(By.CssSelector("[class ='form-control']")).Clear();
        _driver.FindElement(By.Id("searchCategory")).Click();
        _driver.FindElement(By.LinkText(searchCat)).Click();
        _driver.FindElement(By.XPath("//a[@id='btnClick']/span")).Click();
        Assert.AreEqual(searchCat +" on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        Assert.AreEqual(searchCat +" in South Africa | Junk Mail", _driver.Title);
        checkAdsonPage();
    }

    [Test, Order(4)]
    public void SearchRegion() {
        // 3 region
        _driver.FindElement(By.CssSelector("[class ='form-control']")).Clear();
        _driver.FindElement(By.Id("sRegion")).Click();
        _driver.FindElement(By.LinkText(searchRegion)).Click();
        _driver.FindElement(By.Id("searchCategory")).Click();
        _driver.FindElement(By.LinkText("All Categories")).Click();
        _driver.FindElement(By.XPath("//a[@id='btnClick']/span")).Click();
        Assert.AreEqual("All Ads on Junk Mail in " + searchRegion, _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        Assert.AreEqual("All Ads in " + searchRegion + " | Junk Mail", _driver.Title);
        checkAdsonPage();
    }

    [Test, Order(5)]
    public void SearchRegionAndKeyword() {

        //1  2 region + keyword
        _driver.FindElement(By.CssSelector("[class ='form-control']")).Clear();
        _driver.FindElement(By.CssSelector("[class ='form-control']")).SendKeys(searchWord);
        _driver.FindElement(By.Id("sRegion")).Click();
        _driver.FindElement(By.LinkText(searchRegion)).Click();
        _driver.FindElement(By.XPath("//a[@id='btnClick']/span")).Click();
        Assert.AreEqual('"' + searchWord + '"' + " in All Ads on Junk Mail in " + searchRegion, _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        Assert.AreEqual("nissan juke in All Ads in " + searchRegion + " | Junk Mail", _driver.Title);
        checkAdsonPage();
    }

    [Test, Order(6)]
    public void SearchRegionAndCategory() {
        _driver.FindElement(By.CssSelector("[class ='form-control']")).Clear();
        _driver.FindElement(By.Id("sRegion")).Click();
        _driver.FindElement(By.LinkText(searchRegion)).Click();
        _driver.FindElement(By.Id("searchCategory")).Click();
        _driver.FindElement(By.LinkText(searchCat)).Click();
        _driver.FindElement(By.XPath("//a[@id='btnClick']/span")).Click();
        Assert.AreEqual(searchCat +" on Junk Mail in " + searchRegion, _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        Assert.AreEqual(searchCat +" in " + searchRegion + " | Junk Mail", _driver.Title);
        checkAdsonPage();
    }

    [Test, Order(7)]
    public void SearchRegionKeywordCategory() {
        _driver.FindElement(By.CssSelector("[class ='form-control']")).Clear();
        _driver.FindElement(By.CssSelector("[class ='form-control']")).SendKeys(searchWord);
        _driver.FindElement(By.Id("searchCategory")).Click();
        _driver.FindElement(By.LinkText(searchCat)).Click();
        _driver.FindElement(By.Id("sRegion")).Click();
        _driver.FindElement(By.LinkText(searchRegion)).Click();
        _driver.FindElement(By.XPath("//a[@id='btnClick']/span")).Click();
        Assert.AreEqual('"' + searchWord + '"' + " in " + searchCat + " on Junk Mail in " + searchRegion, _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        Assert.AreEqual("nissan juke in "+ searchCat + " in " + searchRegion + " | Junk Mail", _driver.Title);
        checkAdsonPage();
    }

    [Test, Order(8)]
    public void SearchKeywordAndCategory() {
        _driver.FindElement(By.CssSelector("[class ='form-control']")).Clear();
        _driver.FindElement(By.CssSelector("[class ='form-control']")).SendKeys(searchWord);
        _driver.FindElement(By.Id("sRegion")).Click();
        _driver.FindElement(By.LinkText("South Africa")).Click();
        _driver.FindElement(By.Id("searchCategory")).Click();
        _driver.FindElement(By.LinkText(searchCat)).Click();
        _driver.FindElement(By.XPath("//a[@id='btnClick']/span")).Click();
        Assert.AreEqual('"' + searchWord + '"' + " in "+ searchCat + " on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        Assert.AreEqual("nissan juke in "+ searchCat + " in South Africa | Junk Mail", _driver.Title);
        checkAdsonPage();
    }

    [Test, Order(9)]
    public void SearchNonExistingAds()
    {
        var searchWord = "thisaddoesntexist";

        _driver.FindElement(By.CssSelector("[class ='form-control']")).Clear();
        _driver.FindElement(By.CssSelector("[class ='form-control']")).SendKeys(searchWord);
        _driver.FindElement(By.XPath("//body[@id='top']/nav")).Click();
        _driver.FindElement(By.XPath("//a[@id='btnClick']/span")).Click();
        Assert.AreEqual('"' + searchWord + '"' + " in "+ searchCat + " on Junk Mail in South Africa", _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[4]/h2")).Text);
        Assert.AreEqual("thisaddoesntexist in "+ searchCat + " in South Africa | Junk Mail", _driver.Title);
        Assert.IsTrue(Regex.IsMatch(_driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[10]/h4")).Text, "^No Adverts[\\s\\S]$"));
    }

    [Test, Order(10)]
    public void ExitTest()
    {
        _driver.Close();
    }

}

