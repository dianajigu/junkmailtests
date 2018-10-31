using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;

[TestFixture]
class AdPlacementCommercial
{
    public IWebDriver _driver;

    public AdPlacementCommercial()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("disable-infobars");
        options.AddArguments("--start-maximized");
        _driver = new ChromeDriver(options);
        _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);
    }

    [Test, Order(1)]
    public void TrucksTrailersBuses()
    {
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Id("Email")).SendKeys("dianajig5u@gmail.com");
        _driver.FindElement(By.LinkText("Commercial Vehicles & Machinery")).Click();
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("categoryName"))).SelectByText("Commercial");
        System.Threading.Thread.Sleep(5000);

        new SelectElement(_driver.FindElement(By.Id("CategoryId"))).SelectByText("Buses");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubCategoryId"))).SelectByText("10 Seater");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("MakeId"))).SelectByText("FAW"); 
        new SelectElement(_driver.FindElement(By.Id("Condition"))).SelectByText("New");
        _driver.FindElement(By.Id("Mileage")).SendKeys("100000");
        _driver.FindElement(By.Id("Hours")).SendKeys("25222");
        _driver.FindElement(By.Id("Year")).SendKeys("1999");
        new SelectElement(_driver.FindElement(By.Id("Intention"))).SelectByText("For Sale");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Id("Price")).SendKeys("200000");
        _driver.FindElement(By.Id("Title")).SendKeys("2013 Fiat Ducat");
        _driver.FindElement(By.Id("Description")).SendKeys("2013 Fiat Ducato MH2 C8 bus, 10 seater . Excellent condition. Only 148 000km. Ready to operate.");
        new SelectElement(_driver.FindElement(By.Id("regionId"))).SelectByText("Limpopo");
        new SelectElement(_driver.FindElement(By.Id("cityId"))).SelectByText("Other");

        _driver.FindElement(By.Id("post-advert")).Click();
        System.Threading.Thread.Sleep(5000);
        Assert.AreEqual("Your ad has been placed successfully.", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);
    }

    [Test, Order(2)]
    public void Machinery()
    {
        _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("categoryName"))).SelectByText("Commercial");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.LinkText("Commercial Vehicles & Machinery")).Click();
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("CategoryId"))).SelectByText("Buses");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubCategoryId"))).SelectByText("10 Seater");
        new SelectElement(_driver.FindElement(By.Id("Condition"))).SelectByText("Used");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("MakeId"))).SelectByText("FAW");
        _driver.FindElement(By.Id("Hours")).SendKeys("252000");
        _driver.FindElement(By.Id("Year")).SendKeys("1999");
        new SelectElement(_driver.FindElement(By.Id("Intention"))).SelectByText("For Sale");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Id("Price")).SendKeys("3500");
        _driver.FindElement(By.Id("Title")).SendKeys("Steel Storage Container");
        _driver.FindElement(By.Id("Description")).SendKeys("Steel Storage Container with shelves and window Ideal for garden tools or general storage Price: R3,500.00 Must collect");
        new SelectElement(_driver.FindElement(By.Id("regionId"))).SelectByText("Limpopo");
        new SelectElement(_driver.FindElement(By.Id("cityId"))).SelectByText("Other");
        _driver.FindElement(By.Id("Email")).SendKeys("dianajig5u@gmail.com");
        _driver.FindElement(By.Id("post-advert")).Click();
        System.Threading.Thread.Sleep(5000);
        Assert.AreEqual("Your ad has been placed successfully.", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);
    }

    [Test, Order(3)]
    public void CommercialSpares()
    {
        _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("categoryName"))).SelectByText("Commercial");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.LinkText("Commercial Spares")).Click();
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("CategoryId"))).SelectByText("Car Spares and Parts");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Brakes");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("Brake Cables");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("MakeId"))).SelectByText("AMC");
        new SelectElement(_driver.FindElement(By.Id("Intention"))).SelectByText("For Sale");
        new SelectElement(_driver.FindElement(By.Id("Condition"))).SelectByText("New");
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Id("Price")).SendKeys("2000");
        _driver.FindElement(By.Id("Title")).SendKeys("Cute little puppy");
        _driver.FindElement(By.Id("Description")).SendKeys("TLB 315SG Stripping for spares. DIFF GEARBOX Cylinders VALVEBANKS BUCKETS HYDRAULIC PUMP TURBO WITH MANIFOLD OIL COOLERS");
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
