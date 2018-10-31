using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;

[TestFixture]
class AdPlacementGeneral
{
    public IWebDriver _driver;

    public AdPlacementGeneral()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("disable-infobars");
        options.AddArguments("--start-maximized");
        _driver = new ChromeDriver(options);
        _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);
    }

    [Test, Order(1)]
    public void PetsAds()
    {
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("categoryName"))).SelectByText("General");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("CategoryId"))).SelectByText("Pets");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Pet Adoption");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("Adopt a Dog or Puppy");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("Intention"))).SelectByText("For Sale");
        System.Threading.Thread.Sleep(5000);
        Assert.AreEqual("Please provide the birth date or age of the animal(s) you are selling. Animals advertised must have a price - Small mammals (hamsters, rabbits, mice, guinea pigs etc.) /poultry /birds = min price R50 each. ALL OTHER animals = min price R100 per animal.", _driver.FindElement(By.CssSelector("[class='alert light-blue']")).Text);
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Id("Price")).SendKeys("2000");
        _driver.FindElement(By.Id("Title")).SendKeys("Cute little puppy");
        _driver.FindElement(By.Id("Description")).SendKeys("Price drastically reduced due to urgent sale now R15000. Handsome thoroughbred puppy with a nature to match. 16h, 4yo. Lovely white markings, gorgeous to look at.");
        new SelectElement(_driver.FindElement(By.Id("regionId"))).SelectByText("Limpopo");
        new SelectElement(_driver.FindElement(By.Id("cityId"))).SelectByText("Other");
        _driver.FindElement(By.Id("Email")).SendKeys("dianajig5u@gmail.com");
        _driver.FindElement(By.Id("post-advert")).Click();
        System.Threading.Thread.Sleep(5000);
        Assert.AreEqual("Your ad has been placed successfully.", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);
    }

    [Test, Order(2)]
    public void GeneralAds()
    {
        _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("categoryName"))).SelectByText("General");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("CategoryId"))).SelectByText("Leisure");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Hobbies and Interests");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("Electronics");
        new SelectElement(_driver.FindElement(By.Id("Condition"))).SelectByText("New");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("Intention"))).SelectByText("For Sale");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Id("Price")).SendKeys("1200");
        _driver.FindElement(By.Id("Title")).SendKeys("Cute little puppy");
        _driver.FindElement(By.Id("Description")).SendKeys("Excellent Condition Elecltronics, The Exterior Is Well Designed With Curvy Lines Making It A Sexy Yet Elegant Medium Sized.");
        new SelectElement(_driver.FindElement(By.Id("regionId"))).SelectByText("Limpopo");
        new SelectElement(_driver.FindElement(By.Id("cityId"))).SelectByText("Other");
        _driver.FindElement(By.Id("Email")).SendKeys("dianajig5u@gmail.com");
        _driver.FindElement(By.Id("post-advert")).Click();
        System.Threading.Thread.Sleep(5000);
        Assert.AreEqual("Your ad has been placed successfully.", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);
    }

    [Test, Order(3)]
    public void ServicesAds()
    {
        _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("categoryName"))).SelectByText("General");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("CategoryId"))).SelectByText("Services");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Events");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("Venue Hire");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("Intention"))).SelectByText("For Sale");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Id("Price")).SendKeys("201200");
        _driver.FindElement(By.Id("Title")).SendKeys("Services and Events");
        _driver.FindElement(By.Id("Description")).SendKeys("Excellent Condition Merc Ignition for Sale. Contact us for more inforation");
        new SelectElement(_driver.FindElement(By.Id("regionId"))).SelectByText("Limpopo");
        new SelectElement(_driver.FindElement(By.Id("cityId"))).SelectByText("Other");
        _driver.FindElement(By.Id("Email")).SendKeys("dianajig5u@gmail.com");
        _driver.FindElement(By.Id("post-advert")).Click();
        System.Threading.Thread.Sleep(5000);
        Assert.AreEqual("Your ad has been placed successfully.", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);
    }

    [Test, Order(4)]
    public void ExitTest()
    {
        _driver.Close();
    }

}




