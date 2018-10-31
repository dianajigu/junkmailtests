using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;

[TestFixture]
class AdPlacementProperties
{
    public IWebDriver _driver;
 
    public AdPlacementProperties()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("disable-infobars");
        options.AddArguments("--start-maximized");
        _driver = new ChromeDriver(options);
        _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);
    }

    [Test, Order(1)]
    public void Residentailproperties()
    {
            System.Threading.Thread.Sleep(5000);
            new SelectElement(_driver.FindElement(By.Id("categoryName"))).SelectByText("Property");
            System.Threading.Thread.Sleep(5000);
            new SelectElement(_driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Residential Properties");
            new SelectElement(_driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("Townhouses");
            new SelectElement(_driver.FindElement(By.Id("Bedrooms"))).SelectByText("1");
            new SelectElement(_driver.FindElement(By.Id("Bathrooms"))).SelectByText("1");
            new SelectElement(_driver.FindElement(By.Id("Garages"))).SelectByText("1");
            new SelectElement(_driver.FindElement(By.Id("Carports"))).SelectByText("1");
            new SelectElement(_driver.FindElement(By.Id("Intention"))).SelectByText("For Rent");
            _driver.FindElement(By.Id("Title")).SendKeys("Residentail Properties to rent ");
            _driver.FindElement(By.Id("AvailableFrom")).Click();
            _driver.FindElement(By.Id("Description")).SendKeys("Residentail Properties to rent in Hoedespriut. An hour drive form the Kruger national park");
            _driver.FindElement(By.Id("LandArea")).SendKeys("200");
            _driver.FindElement(By.Id("FloorArea")).SendKeys("100");
            _driver.FindElement(By.Id("RatesAndTaxes")).SendKeys("1850");
            _driver.FindElement(By.Id("Levies")).SendKeys("198");
            _driver.FindElement(By.Id("Furnished")).Click();
            _driver.FindElement(By.Id("PetFriendly")).Click();
            _driver.FindElement(By.Id("IsTrade")).Click();
            _driver.FindElement(By.Id("Price")).SendKeys("2000");
            new SelectElement(_driver.FindElement(By.Id("regionId"))).SelectByText("Limpopo");
            new SelectElement(_driver.FindElement(By.Id("cityId"))).SelectByText("Other");
            _driver.FindElement(By.Id("Email")).SendKeys("dianajigu@gmail.com");
            _driver.FindElement(By.Id("post-advert")).Click();
            Assert.AreEqual("Your ad has been placed successfully.", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);

    }

    [Test, Order(2)]
    public void Commercialproperties()
    {
            _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
            new SelectElement(_driver.FindElement(By.Id("categoryName"))).SelectByText("Property");
            System.Threading.Thread.Sleep(5000);
            new SelectElement(_driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Commercial Property");
            new SelectElement(_driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("Retail Property");
            //new SelectElement(driver.FindElement(By.Id("Bedrooms"))).SelectByText("1");
            //new SelectElement(driver.FindElement(By.Id("Bathrooms"))).SelectByText("1");
            //new SelectElement(driver.FindElement(By.Id("Garages"))).SelectByText("1");
            //new SelectElement(driver.FindElement(By.Id("Carports"))).SelectByText("1");
            new SelectElement(_driver.FindElement(By.Id("Intention"))).SelectByText("For Rent");
            _driver.FindElement(By.Id("Title")).SendKeys("Commercial Properties to rent ");
            _driver.FindElement(By.Id("AvailableFrom")).Click();
            _driver.FindElement(By.Id("Description")).SendKeys("Commercial Properties to rent in Pretoria Centurion. An hour drive form the CBD");
            _driver.FindElement(By.Id("LandArea")).SendKeys("200");
            _driver.FindElement(By.Id("FloorArea")).SendKeys("100");
            _driver.FindElement(By.Id("RatesAndTaxes")).SendKeys("1850");
            _driver.FindElement(By.Id("Levies")).SendKeys("198");
            //driver.FindElement(By.Id("Furnished")).Click();
            //driver.FindElement(By.Id("PetFriendly")).Click();
            _driver.FindElement(By.Id("IsTrade")).Click();
            _driver.FindElement(By.Id("Price")).SendKeys("2000");
            new SelectElement(_driver.FindElement(By.Id("regionId"))).SelectByText("Gauteng");
            new SelectElement(_driver.FindElement(By.Id("cityId"))).SelectByText("Pretoria");
            new SelectElement(_driver.FindElement(By.Id("suburbId"))).SelectByText("Centurion");
            _driver.FindElement(By.Id("Email")).SendKeys("dianajigu@gmail.com");
            _driver.FindElement(By.Id("post-advert")).Click();
            System.Threading.Thread.Sleep(5000);
            Assert.AreEqual("Your ad has been placed successfully.", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);
    }

    [Test, Order(3)]
    public void FarmProperties()
    {
            _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
            new SelectElement(_driver.FindElement(By.Id("categoryName"))).SelectByText("Property");
            System.Threading.Thread.Sleep(5000);
            new SelectElement(_driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Farms");
            new SelectElement(_driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("Grazing Land");
            //new SelectElement(driver.FindElement(By.Id("Bedrooms"))).SelectByText("1");
            //new SelectElement(driver.FindElement(By.Id("Bathrooms"))).SelectByText("1");
            //new SelectElement(driver.FindElement(By.Id("Garages"))).SelectByText("1");
            //new SelectElement(driver.FindElement(By.Id("Carports"))).SelectByText("1");
            new SelectElement(_driver.FindElement(By.Id("Intention"))).SelectByText("For Rent");
            _driver.FindElement(By.Id("Title")).SendKeys("Pig and mushroom to rent ");
            //driver.FindElement(By.Id("AvailableFrom")).Click();
            _driver.FindElement(By.Id("Description")).SendKeys("Farm for rent in Pretoria Hatifield. Long term lease. Arrable land");
            _driver.FindElement(By.Id("LandArea")).SendKeys("200");
            // driver.FindElement(By.Id("FloorArea")).SendKeys("100");
            //  driver.FindElement(By.Id("RatesAndTaxes")).SendKeys("1850");
            //  driver.FindElement(By.Id("Levies")).SendKeys("198");
            //driver.FindElement(By.Id("Furnished")).Click();
            //driver.FindElement(By.Id("PetFriendly")).Click();
            _driver.FindElement(By.Id("IsTrade")).Click();
            _driver.FindElement(By.Id("Price")).SendKeys("2000");
            new SelectElement(_driver.FindElement(By.Id("regionId"))).SelectByText("Limpopo");
            new SelectElement(_driver.FindElement(By.Id("cityId"))).SelectByText("Other");
            _driver.FindElement(By.Id("Email")).SendKeys("dianajigu@gmail.com");
            _driver.FindElement(By.Id("post-advert")).Click();
            System.Threading.Thread.Sleep(5000);
            Assert.AreEqual("Your ad has been placed successfully.", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);
    }

    [Test, Order(4)]
    public void VacantLand()
    {
             _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
            new SelectElement(_driver.FindElement(By.Id("categoryName"))).SelectByText("Property");
            new SelectElement(_driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Vacant Land");
            new SelectElement(_driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("Farming Land");
            //new SelectElement(driver.FindElement(By.Id("Bedrooms"))).SelectByText("1");
            //new SelectElement(driver.FindElement(By.Id("Bathrooms"))).SelectByText("1");
            //new SelectElement(driver.FindElement(By.Id("Garages"))).SelectByText("1");
            //new SelectElement(driver.FindElement(By.Id("Carports"))).SelectByText("1");
            new SelectElement(_driver.FindElement(By.Id("Intention"))).SelectByText("For Rent");
            _driver.FindElement(By.Id("Title")).SendKeys("Vacant Land - Properties to rent ");
            //driver.FindElement(By.Id("AvailableFrom")).Click();
            _driver.FindElement(By.Id("Description")).SendKeys("Vacant land for sale in KZN West. Located close to schools, malls and hospiatls");
            _driver.FindElement(By.Id("LandArea")).SendKeys("200");
            // driver.FindElement(By.Id("FloorArea")).SendKeys("100");
            //  driver.FindElement(By.Id("RatesAndTaxes")).SendKeys("1850");
            //  driver.FindElement(By.Id("Levies")).SendKeys("198");
            //driver.FindElement(By.Id("Furnished")).Click();
            //driver.FindElement(By.Id("PetFriendly")).Click();
            _driver.FindElement(By.Id("IsTrade")).Click();
            _driver.FindElement(By.Id("Price")).SendKeys("2000");
            new SelectElement(_driver.FindElement(By.Id("regionId"))).SelectByText("KwaZulu-Natal");
            new SelectElement(_driver.FindElement(By.Id("cityId"))).SelectByText("Ballito");
            _driver.FindElement(By.Id("Email")).SendKeys("dianajigu@gmail.com");
            _driver.FindElement(By.Id("post-advert")).Click();
            System.Threading.Thread.Sleep(5000);
            Assert.AreEqual("Your ad has been placed successfully.", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);

    }

    [Test, Order(5)]
    public void SharedProperties()
    {
            _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
            new SelectElement(_driver.FindElement(By.Id("categoryName"))).SelectByText("Property");
            System.Threading.Thread.Sleep(5000);
            new SelectElement(_driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Shared Accommodation");
            new SelectElement(_driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("Rooms to Share");
            //new SelectElement(driver.FindElement(By.Id("Bedrooms"))).SelectByText("1");
            //new SelectElement(driver.FindElement(By.Id("Bathrooms"))).SelectByText("1");
            //new SelectElement(driver.FindElement(By.Id("Garages"))).SelectByText("1");
            //new SelectElement(driver.FindElement(By.Id("Carports"))).SelectByText("1");
            new SelectElement(_driver.FindElement(By.Id("Intention"))).SelectByText("For Rent");
            _driver.FindElement(By.Id("Title")).SendKeys("Student Accomodation to share ");
            //driver.FindElement(By.Id("AvailableFrom")).Click();
            _driver.FindElement(By.Id("Description")).SendKeys("Student Accomodation to share in Pretoria Hatfield. Close to University");
            //driver.FindElement(By.Id("LandArea")).SendKeys("200");
            // driver.FindElement(By.Id("FloorArea")).SendKeys("100");
            //  driver.FindElement(By.Id("RatesAndTaxes")).SendKeys("1850");
            //  driver.FindElement(By.Id("Levies")).SendKeys("198");
            _driver.FindElement(By.Id("Furnished")).Click();
            _driver.FindElement(By.Id("PetFriendly")).Click();
            _driver.FindElement(By.Id("IsTrade")).Click();
            _driver.FindElement(By.Id("Price")).SendKeys("2000");
            new SelectElement(_driver.FindElement(By.Id("regionId"))).SelectByText("Gauteng");
            new SelectElement(_driver.FindElement(By.Id("cityId"))).SelectByText("Pretoria");
            new SelectElement(_driver.FindElement(By.Id("suburbId"))).SelectByText("Pretoria East");
            _driver.FindElement(By.Id("Email")).SendKeys("dianajigu@gmail.com");
            _driver.FindElement(By.Id("post-advert")).Click();
            System.Threading.Thread.Sleep(5000);
            Assert.AreEqual("Your ad has been placed successfully.", _driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);

    }

    [Test, Order(6)]
    public void HolidayAccomodation()
    {
        _driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        new SelectElement(_driver.FindElement(By.Id("categoryName"))).SelectByText("Property");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(_driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Holiday Accommodation");
        new SelectElement(_driver.FindElement(By.Id("SubSubCategoryId"))).SelectByText("Holiday Homes");
        new SelectElement(_driver.FindElement(By.Id("Bedrooms"))).SelectByText("1");
        new SelectElement(_driver.FindElement(By.Id("Bathrooms"))).SelectByText("1");
        //new SelectElement(driver.FindElement(By.Id("Garages"))).SelectByText("1");
        //new SelectElement(driver.FindElement(By.Id("Carports"))).SelectByText("1");
        new SelectElement(_driver.FindElement(By.Id("Intention"))).SelectByText("For Rent");
        _driver.FindElement(By.Id("Title")).SendKeys("Commercial Properties to rent ");
        //driver.FindElement(By.Id("AvailableFrom")).Click();
        _driver.FindElement(By.Id("Description")).SendKeys("Commercial Properties to rent in Pretoria Hatifield. An hour drive form the CBD");
        //driver.FindElement(By.Id("LandArea")).SendKeys("200");
        // driver.FindElement(By.Id("FloorArea")).SendKeys("100");
        //  driver.FindElement(By.Id("RatesAndTaxes")).SendKeys("1850");
        //  driver.FindElement(By.Id("Levies")).SendKeys("198");
        _driver.FindElement(By.Id("Furnished")).Click();
        _driver.FindElement(By.Id("PetFriendly")).Click();
        _driver.FindElement(By.Id("IsTrade")).Click();
        _driver.FindElement(By.Id("Price")).SendKeys("2000");
        new SelectElement(_driver.FindElement(By.Id("regionId"))).SelectByText("North West");
        new SelectElement(_driver.FindElement(By.Id("cityId"))).SelectByText("Mahikeng");
        _driver.FindElement(By.Id("Email")).SendKeys("dianajigu@gmail.com");
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

