using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;

class AdPlacementMotoring
{
    public IWebDriver driver;

    public AdPlacementMotoring()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("disable-infobars");
        options.AddArguments("--start-maximized");
        driver = new ChromeDriver(options);
        driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);
    }

   
    [Test, Order(1)]
    public void CarAds()
    {
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("categoryName"))).SelectByText("Motoring");
        System.Threading.Thread.Sleep(5000);
        driver.FindElement(By.LinkText("Cars")).Click();
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Audi");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("A1");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("ModelVariantId"))).SelectByText("1.2T S");
        new SelectElement(driver.FindElement(By.Id("Color"))).SelectByText("Black");
        driver.FindElement(By.Id("Mileage")).SendKeys("20555");
        driver.FindElement(By.Id("Year")).SendKeys("2017"); 
        new SelectElement(driver.FindElement(By.Id("Condition"))).SelectByText("New");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("Intention"))).SelectByText("For Sale");
        System.Threading.Thread.Sleep(5000);
        driver.FindElement(By.Id("Price")).SendKeys("201200");
        driver.FindElement(By.Id("Description")).SendKeys("Excellent Condition With Mags And New Tires, The Exterior Is Well Designed With Curvy Lines Making It A Sexy Yet Elegant Medium Sized Car.");
        new SelectElement(driver.FindElement(By.Id("regionId"))).SelectByText("Limpopo");
        new SelectElement(driver.FindElement(By.Id("cityId"))).SelectByText("Other");
        driver.FindElement(By.Id("Email")).SendKeys("dianajig5u@gmail.com");
        driver.FindElement(By.Id("post-advert")).Click();
        System.Threading.Thread.Sleep(5000);
        Assert.AreEqual("Your ad has been placed successfully.", driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);
        Console.WriteLine("cars" + DateTime.Now);
    }

    [Test, Order(2)]
    public void BikeAds()
    {
        driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("categoryName"))).SelectByText("Motoring");
        System.Threading.Thread.Sleep(5000);
        driver.FindElement(By.LinkText("Bikes")).Click();
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("SubCategoryId"))).SelectByText("BMW");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("C1");
        new SelectElement(driver.FindElement(By.Id("Color"))).SelectByText("Black");
        driver.FindElement(By.Id("Mileage")).SendKeys("20555");
        driver.FindElement(By.Id("Year")).SendKeys("2017");
        new SelectElement(driver.FindElement(By.Id("Condition"))).SelectByText("New");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("Intention"))).SelectByText("For Sale");
        System.Threading.Thread.Sleep(5000);
        driver.FindElement(By.Id("Price")).SendKeys("201200");
        driver.FindElement(By.Id("Description")).SendKeys("Excellent Condition With Mags And New Tires, The Exterior Is Well Designed With Curvy Lines Making It A Sexy Yet Elegant Medium Sized Car.");
        new SelectElement(driver.FindElement(By.Id("regionId"))).SelectByText("Limpopo");
        new SelectElement(driver.FindElement(By.Id("cityId"))).SelectByText("Other");
        driver.FindElement(By.Id("Email")).SendKeys("dianajig5u@gmail.com");
        driver.FindElement(By.Id("post-advert")).Click();
        System.Threading.Thread.Sleep(5000);
        Assert.AreEqual("Your ad has been placed successfully.", driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);
        Console.WriteLine("bikes" + DateTime.Now);
    }

    [Test, Order(3)]
    public void SparesAds()
    {
        driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("categoryName"))).SelectByText("Motoring");
        System.Threading.Thread.Sleep(5000);
        driver.FindElement(By.LinkText("Car Spares and Parts")).Click();
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Ignition");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("Distributors");
        new SelectElement(driver.FindElement(By.Id("MakeId"))).SelectByText("AC");
        //    driver.FindElement(By.Id("Mileage")).SendKeys("20555");
        //  driver.FindElement(By.Id("Year")).SendKeys("2017");
        new SelectElement(driver.FindElement(By.Id("Condition"))).SelectByText("New");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("Intention"))).SelectByText("For Sale");
        System.Threading.Thread.Sleep(5000);
        driver.FindElement(By.Id("Price")).SendKeys("201200");
        driver.FindElement(By.Id("Title")).SendKeys("Merc Ignition for Sale");
        driver.FindElement(By.Id("Description")).SendKeys("Excellent Condition Merc Ignition for Sale. Contact us for more inforation");
        new SelectElement(driver.FindElement(By.Id("regionId"))).SelectByText("Limpopo");
        new SelectElement(driver.FindElement(By.Id("cityId"))).SelectByText("Other");
        driver.FindElement(By.Id("Email")).SendKeys("dianajig5u@gmail.com");
        driver.FindElement(By.Id("post-advert")).Click();
        System.Threading.Thread.Sleep(5000);
        Assert.AreEqual("Your ad has been placed successfully.", driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);
        Console.WriteLine("spares" + DateTime.Now);
    }

    [Test, Order(4)]
    public void OtherMotoring()
    {
        driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("categoryName"))).SelectByText("Motoring");
        System.Threading.Thread.Sleep(5000);
        driver.FindElement(By.LinkText("Trailers")).Click();
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Trailers");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("Venter Trailers");
        //new SelectElement(driver.FindElement(By.Id("MakeId"))).SelectByText("AC");
        //    driver.FindElement(By.Id("Mileage")).SendKeys("20555");
        //  driver.FindElement(By.Id("Year")).SendKeys("2017");
        new SelectElement(driver.FindElement(By.Id("Condition"))).SelectByText("New");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("Intention"))).SelectByText("For Sale");
        System.Threading.Thread.Sleep(5000);
        driver.FindElement(By.Id("Price")).SendKeys("201200");
        driver.FindElement(By.Id("Title")).SendKeys("Best fully equiped Fast Food Trailers ");
        driver.FindElement(By.Id("Description")).SendKeys("Excellent Condition Fast Food Trailers for Sale. Contact us for more information");
        new SelectElement(driver.FindElement(By.Id("regionId"))).SelectByText("Limpopo");
        new SelectElement(driver.FindElement(By.Id("cityId"))).SelectByText("Other");
        driver.FindElement(By.Id("Email")).SendKeys("dianajig5u@gmail.com");
        driver.FindElement(By.Id("post-advert")).Click();
        System.Threading.Thread.Sleep(5000);
        Assert.AreEqual("Your ad has been placed successfully.", driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);
        Console.WriteLine("other" + DateTime.Now);
    }
}




