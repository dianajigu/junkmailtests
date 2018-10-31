using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;

[TestFixture]
class AdPlacementFarming
{
    public IWebDriver _driver;

    public AdPlacementFarming()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("disable-infobars");
        options.AddArguments("--start-maximized");
        _driver = new ChromeDriver(options);
        _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);
    }

    [Test, Order(1)]
    public void FarmsAds()
    {
        _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("categoryName"))).SelectByText("Farming");
         System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.LinkText("Farms")).Click();
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Farms");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("Grazing Land");
        System.Threading.Thread.Sleep(5000);
        //new SelectElement(driver.FindElement(By.Id("MakeId"))).SelectByText("Aco");
        _driver.FindElement(By.Id("LandArea")).SendKeys("25345222");
       // new SelectElement(_driver.FindElement(By.Id("Condition"))).SelectByIndex(1);
        //driver.FindElement(By.Id("Year")).SendKeys("1999");
        new SelectElement(_driver.FindElement(By.Id("Intention"))).SelectByText("For Sale");
        System.Threading.Thread.Sleep(5000);
        // Assert.AreEqual("Please provide the birth date or age of the animal(s) you are selling. Animals advertised must have a price - Small mammals (hamsters, rabbits, mice, guinea pigs etc.) /poultry /birds = min price R50 each. ALL OTHER animals = min price R100 per animal.", driver.FindElement(By.CssSelector("[class='alert light-blue']")).Text);
        // System.Threading.Thread.Sleep(5000);
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
    public void FarmingAds()
    {
        _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("categoryName"))).SelectByText("Farming");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.LinkText("Farming")).Click();
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Cultivators");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("Harrows");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("MakeId"))).SelectByText("Aco");
        _driver.FindElement(By.Id("Hours")).SendKeys("25222");
        _driver.FindElement(By.Id("Year")).SendKeys("1999");
        new SelectElement(_driver.FindElement(By.Id("Condition"))).SelectByIndex(2);
        new SelectElement(_driver.FindElement(By.Id("Intention"))).SelectByText("For Sale");
        System.Threading.Thread.Sleep(5000);
      //  Assert.AreEqual("Please provide the birth date or age of the animal(s) you are selling. Animals advertised must have a price - Small mammals (hamsters, rabbits, mice, guinea pigs etc.) /poultry /birds = min price R50 each. ALL OTHER animals = min price R100 per animal.", _driver.FindElement(By.CssSelector("[class='alert light-blue']")).Text);
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

    

    [Test, Order(3)]
    public void FarmSparesAndPartsAds()
    {
        _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);

        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("categoryName"))).SelectByText("Farming");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.LinkText("Hunting")).Click();
        System.Threading.Thread.Sleep(5000);
     //   new SelectElement(_driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Hunting");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("Bows");
        System.Threading.Thread.Sleep(5000);
        //new SelectElement(driver.FindElement(By.Id("MakeId"))).SelectByText("Aco");
        //driver.FindElement(By.Id("LandArea")).SendKeys("25345222");
        //driver.FindElement(By.Id("Year")).SendKeys("1999");
        new SelectElement(_driver.FindElement(By.Id("Intention"))).SelectByText("For Sale");
        System.Threading.Thread.Sleep(5000);
        // Assert.AreEqual("Please provide the birth date or age of the animal(s) you are selling. Animals advertised must have a price - Small mammals (hamsters, rabbits, mice, guinea pigs etc.) /poultry /birds = min price R50 each. ALL OTHER animals = min price R100 per animal.", driver.FindElement(By.CssSelector("[class='alert light-blue']")).Text);
        // System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Id("Price")).SendKeys("2000");
        new SelectElement(_driver.FindElement(By.Id("Condition"))).SelectByIndex(1);
        _driver.FindElement(By.Id("Title")).SendKeys("Cute little puppy");
        _driver.FindElement(By.Id("Description")).SendKeys("Price drastically reduced due to urgent sale now R15000. Handsome thoroughbred puppy with a nature to match. 16h, 4yo. Lovely white markings, gorgeous to look at.");
        new SelectElement(_driver.FindElement(By.Id("regionId"))).SelectByText("Limpopo");
        new SelectElement(_driver.FindElement(By.Id("cityId"))).SelectByText("Other");
        _driver.FindElement(By.Id("Email")).SendKeys("dianajig5u@gmail.com");
        _driver.FindElement(By.Id("post-advert")).Click();
        System.Threading.Thread.Sleep(5000);
        Assert.AreEqual("Your ad has been placed successfully.", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);
    }

    [Test, Order(4)]
    public void HuntingAds()
    {
        _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("categoryName"))).SelectByText("Farming");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.LinkText("Farm Spares and Parts")).Click();
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Transmission");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("Gearsticks");
        System.Threading.Thread.Sleep(5000);
        //new SelectElement(driver.FindElement(By.Id("MakeId"))).SelectByText("Aco");
        //driver.FindElement(By.Id("LandArea")).SendKeys("25345222");
        //driver.FindElement(By.Id("Year")).SendKeys("1999");
        new SelectElement(_driver.FindElement(By.Id("Intention"))).SelectByText("For Sale");
        System.Threading.Thread.Sleep(5000);
        // Assert.AreEqual("Please provide the birth date or age of the animal(s) you are selling. Animals advertised must have a price - Small mammals (hamsters, rabbits, mice, guinea pigs etc.) /poultry /birds = min price R50 each. ALL OTHER animals = min price R100 per animal.", driver.FindElement(By.CssSelector("[class='alert light-blue']")).Text);
        // System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Id("Price")).SendKeys("2000");
        new SelectElement(_driver.FindElement(By.Id("Condition"))).SelectByIndex(2);
        _driver.FindElement(By.Id("Title")).SendKeys("Cute little puppy");
        _driver.FindElement(By.Id("Description")).SendKeys("Price drastically reduced due to urgent sale now R15000. Handsome thoroughbred puppy with a nature to match. 16h, 4yo. Lovely white markings, gorgeous to look at.");
        new SelectElement(_driver.FindElement(By.Id("regionId"))).SelectByText("Limpopo");
        new SelectElement(_driver.FindElement(By.Id("cityId"))).SelectByText("Other");
        _driver.FindElement(By.Id("Email")).SendKeys("dianajig5u@gmail.com");
        _driver.FindElement(By.Id("post-advert")).Click();
        System.Threading.Thread.Sleep(5000);
        Assert.AreEqual("Your ad has been placed successfully.", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);
    }

    [Test, Order(5)]
    public void ExitTest()
    {
        _driver.Close();
    }

}




