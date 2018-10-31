using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;

[TestFixture]
class DetailsPage  {

    public IWebDriver _driver;

    public DetailsPage()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("disable-infobars");
        options.AddArguments("--start-maximized");
        _driver = new ChromeDriver(options);
        System.Threading.Thread.Sleep(5000);
  
    }

    [Test, Order(1)]
    public void PetsDetails()
    {
        _driver.Url = "https://www.junkmail.co.za/pets/horses-and-ponies/cape-town/for-sale/pr10000";
        //pets - horses and ponies - cape-town - for-sale - for-sale - 10000+

        String adTitle = _driver.FindElement(By.CssSelector("[class='h2']")).Text;
        String adPrice = _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[8]/div[2]/div/div/div/h3/span")).Text;

        _driver.FindElement(By.LinkText("Contact Advertiser")).Click();
        Assert.AreEqual("Pets - Horses and Ponies", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[2]/div/div[2]/ul/li/b")).Text);
        Assert.AreEqual("Western Cape - Cape Town", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[2]/div/div[2]/ul/li[2]/b")).Text);
        Assert.AreEqual(adTitle, _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[3]/div/div/h1")).Text);
        Assert.AreEqual(adPrice, _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[3]/div/div/div/b")).Text);
        Assert.AreEqual("Important pet information! We care about the wellbeing of all the pets on Junk Mail. Find out more about our Pet Policy here.", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[3]/div[2]/div/div[4]/p")).Text);
    }

    [Test, Order(2)]
    public void PropertyDetails()
    {
        _driver.Url = "https://www.junkmail.co.za/property/residential-properties/apartments-and-flats/gauteng/pretoria/for-rent/pr4000-6000";

        String adTitle = _driver.FindElement(By.CssSelector("[class='h2']")).Text;
        String adPrice = _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[8]/div[2]/div/div/div/h3/span")).Text;
        
        _driver.FindElement(By.LinkText("Contact Advertiser")).Click();
        Assert.AreEqual("Property - Residential Properties - Apartments and Flats", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[2]/div/div[2]/ul/li/b")).Text);
        Assert.AreEqual("Gauteng - Pretoria", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[2]/div/div[2]/ul/li[5]/b")).Text);
        Assert.AreEqual(adTitle, _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[3]/div/div/h1")).Text);
        Assert.AreEqual(adPrice, _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[3]/div/div/div/b")).Text);
        _driver.FindElement(By.CssSelector("[class='prop-bed']"));
        _driver.FindElement(By.CssSelector("[class='prop-bath']"));
    }

    [Test, Order(3)]
    public void MotoringDetails()
    {
        
        _driver.Url = "https://www.junkmail.co.za/cars/bmw/gauteng/johannesburg/u-0a0abc63b893462296159b1a514ea623";

        String adTitle = _driver.FindElement(By.CssSelector("[class='h2']")).Text;
        String adPrice = _driver.FindElement(By.XPath("//body[@id='top']/section/div/div/div[2]/div[8]/div[2]/div/div/div/h3/span")).Text;

        int titleLength = adTitle.Length ;
        int newlength = titleLength - 5;

        string str = null;
        string VehicleMake = null;
        str = adTitle;
        VehicleMake = str.Substring(5, newlength);
        string Year = str.Substring(0, 4);
        _driver.FindElement(By.LinkText("Contact Advertiser")).Click();
        Assert.AreEqual(VehicleMake, _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[2]/div/div[2]/ul/li/b")).Text);
        Assert.AreEqual(Year, _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[2]/div/div[2]/ul/li[4]/b")).Text);
        Assert.AreEqual("Used", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[2]/div/div[2]/ul/li[5]/b")).Text);
        Assert.AreEqual("Gauteng - Johannesburg", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[2]/div/div[2]/ul/li[6]/b")).Text);
        Assert.AreEqual(adTitle, _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[3]/div/div/h1")).Text);
        Assert.AreEqual(adPrice, _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[3]/div/div/div/b")).Text);
    }

    [Test, Order(4)]
    public void JobDetails()
    {

        _driver.Url = "https://www.junkmail.co.za/jobs/gauteng/johannesburg/u-3cfcac2e6f62d395e5d4f960";

        String adTitle = _driver.FindElement(By.CssSelector("[class='h2']")).Text;
        _driver.FindElement(By.LinkText("Contact Advertiser")).Click();
        Assert.AreEqual("Jobs - Part Time and Temporary", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[2]/div/div[2]/ul/li/b")).Text);
        Assert.AreEqual("Gauteng - Johannesburg", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[2]/div/div[2]/ul/li[3]/b")).Text);
        Assert.AreEqual("Per Month", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[2]/div/div[2]/ul/li[2]/b")).Text);
        Assert.AreEqual(adTitle, _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[3]/div/div/h1")).Text);            
    }

    [Test, Order(5)]
    public void GeneralDetails() {
        _driver.Url = "https://www.junkmail.co.za/business-directory/magic-deals-montana/household/furniture/gauteng/pretoria/pretoria-north/u-fd7307990b2cc420c942f13d";

        String adTitle = _driver.FindElement(By.CssSelector("[class='h2']")).Text;
        _driver.FindElement(By.LinkText("Contact Advertiser")).Click();
        Assert.AreEqual("Household - Furniture - Living Room Furniture", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[2]/div/div[2]/ul/li/b")).Text);
        Assert.AreEqual("Gauteng - Pretoria", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[2]/div/div[2]/ul/li[3]/b")).Text);
        Assert.AreEqual(adTitle, _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div[3]/div/div/h1")).Text);
    }

    [Test, Order(6)]
    public void Reportadvert() {
        _driver.Url = "https://www.junkmail.co.za/property/residential-properties/gauteng/pretoria/pretoria-east/2-bedroom-flat-available-in-garsfontein/5d25e5bc52294ebf8dfb3c2371156f58";
        _driver.FindElement(By.Id("scam-link")).Click();
        _driver.FindElement(By.Id("submit-report-button")).Click();
        _driver.FindElement(By.Id("report-email")).SendKeys("dianajigu@gmail.com");
        new SelectElement(_driver.FindElement(By.Id("report-reason"))).SelectByText("Scam");
        _driver.FindElement(By.Id("Cell")).SendKeys("0734384753");
        _driver.FindElement(By.Id("Message")).SendKeys("Hi Admin, this is a test, please ignore");
        _driver.FindElement(By.Id("submit-report-button")).Click();
        System.Threading.Thread.Sleep(5000);
        Assert.AreEqual("Thank you for your feedback - this advert has been flagged for review.", _driver.FindElement(By.Id("report-success")).Text);
        _driver.FindElement(By.XPath("//div[@id='scam-report-div']/div/span/button/i")).Click();
    }

    [Test, Order(7)]
    public void ContactAdvertiser() { 
        _driver.FindElement(By.Id("Name")).SendKeys("Diana Jigu");
        _driver.FindElement(By.Id("Phone")).SendKeys("0734384753");
        _driver.FindElement(By.Id("Email")).SendKeys("dianajigu@gmail.com");
        _driver.FindElement(By.Id("Name")).SendKeys("Diana");
        _driver.FindElement(By.Id("btnSubmitLead")).Click();
        System.Threading.Thread.Sleep(5000);
        Assert.AreEqual("Success!", _driver.FindElement(By.XPath("//div[@id='contactSeller']/div/h2")).Text);
    }

    [Test, Order(8)]
    public void ExitTest()
    {
        _driver.Close();
    }

}
