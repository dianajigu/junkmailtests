using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;

[TestFixture]
class AdPlacementJobs
{
    public IWebDriver driver;

    public AdPlacementJobs()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("disable-infobars");
        options.AddArguments("--start-maximized");
        driver = new ChromeDriver(options);
        driver.Url = "https://junkmail.dsdemo.co.za/place-advert";
        System.Threading.Thread.Sleep(5000);
    }

    [Test, Order(1)]
    public void FormalJobs()
    {
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("categoryName"))).SelectByText("Jobs");
        System.Threading.Thread.Sleep(5000);
        driver.FindElement(By.LinkText("Formal")).Click();
        System.Threading.Thread.Sleep(5000);
        driver.FindElement(By.CssSelector("[class='close-modal btn btn-default btn-round']")).Click(); 
    }

    [Test, Order(2)]
    public void ValidatePriceFields()
    {
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("categoryName"))).SelectByText("Jobs");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Job Seekers");
        driver.FindElement(By.Id("salaryMin")).SendKeys("test");
        driver.FindElement(By.Id("salaryMax")).SendKeys("test");
        driver.FindElement(By.Id("post-advert")).Click();
        System.Threading.Thread.Sleep(5000);
        Assert.AreEqual("The field SalaryMin must be a number.", driver.FindElement(By.Id("salaryMin-error")).Text);
        Assert.AreEqual("The field SalaryMax must be a number.", driver.FindElement(By.Id("salaryMax-error")).Text);
    }

    [Test, Order(3)]
    public void Jobs()
    {
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("categoryName"))).SelectByText("Jobs");
        System.Threading.Thread.Sleep(5000);
        new SelectElement(driver.FindElement(By.Id("SubCategoryId"))).SelectByText("Job Seekers");           
        new SelectElement(driver.FindElement(By.Id("PaymentSchedule"))).SelectByText("Per Hour");
        driver.FindElement(By.Id("Title")).SendKeys("Swimming coach available");
        driver.FindElement(By.Id("Description")).SendKeys("Swimming coach availabe in Pretoria East. Coaching kids and grownups");
        driver.FindElement(By.Id("salaryMin")).Clear();
        driver.FindElement(By.Id("salaryMin")).SendKeys("200");
        driver.FindElement(By.Id("salaryMax")).Clear();
        driver.FindElement(By.Id("salaryMax")).SendKeys("1000");
        new SelectElement(driver.FindElement(By.Id("regionId"))).SelectByText("Limpopo");
        new SelectElement(driver.FindElement(By.Id("cityId"))).SelectByText("Other");
        driver.FindElement(By.Id("Email")).SendKeys("dianajigu@gmail.com");
        driver.FindElement(By.Id("post-advert")).Click();
        Assert.AreEqual("Your ad has been placed successfully.", driver.FindElement(By.XPath("//body[@id='top']/div/div/div/div/div/div/h4")).Text);
    }
}

