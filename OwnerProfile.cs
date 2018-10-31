using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


    [TestFixture]
    public class OwnerProfile
    {
    private IWebDriver _driver;

    public OwnerProfile()
    {
        _driver = new FirefoxDriver();
        _driver.Url = "http://junkmail.co.za/login";
        System.Threading.Thread.Sleep(5000);
    }


        [Test, Order(1)]
    public void Login()
    {
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Name("Email")).SendKeys("diana@dotslash.co.za");
        _driver.FindElement(By.Name("Password")).SendKeys("1234567");
        _driver.FindElement(By.Id("btnLogin")).Click();
        System.Threading.Thread.Sleep(5000);
    }


    [Test, Order(2)]
    public void ChangePassword()
    {
        _driver.Navigate().GoToUrl("https://accounts.junkmail.co.za/profile");
        System.Threading.Thread.Sleep(5000);

        string submitpassword = "(.//*[normalize-space(text()) and normalize-space(.)='Change Password'])[1]/following::div[2]";

        //submit correct password
        _driver.FindElement(By.Id("changePassword_CurrentPassword")).SendKeys("1234567");
        _driver.FindElement(By.Id("changePassword_NewPassword")).SendKeys("1234567");
        _driver.FindElement(By.XPath(submitpassword)).Click();
    }

    [Test, Order(3)]
    public void ValidateProfile() {
        new SelectElement(_driver.FindElement(By.Id("User_RegionID"))).SelectByText("Gauteng");
        new SelectElement(_driver.FindElement(By.Id("User_CityID"))).SelectByText("Pretoria");
        new SelectElement(_driver.FindElement(By.Id("User_SuburbID"))).SelectByText("Atteridgeville");
        _driver.FindElement(By.Id("user_FirstName")).Clear();
        _driver.FindElement(By.Id("user_LastName")).Clear();
        _driver.FindElement(By.Id("user_Cell")).Clear();
        _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Landline Number'])[1]/following::button[1]")).Click();
        Assert.AreEqual("Your Frist Name is required", _driver.FindElement(By.Id("user_FirstName-error")).Text);
        Assert.AreEqual("Your Last Name is required", _driver.FindElement(By.Id("user_LastName-error")).Text);
        Assert.AreEqual("Your Cell Number is required", _driver.FindElement(By.Id("user_Cell-error")).Text);
    }

    [Test, Order(4)]
    public void SubmitProfile() { 
        _driver.FindElement(By.Id("user_FirstName")).Clear();
        _driver.FindElement(By.Id("user_FirstName")).SendKeys("Claire");
        _driver.FindElement(By.Id("user_LastName")).Clear();
        _driver.FindElement(By.Id("user_LastName")).SendKeys("Jones");
        _driver.FindElement(By.Id("user_Cell")).Clear();
        _driver.FindElement(By.Id("user_Cell")).SendKeys("0774441111");
        _driver.FindElement(By.Id("user_Tel")).Clear();
        _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Landline Number'])[1]/following::button[1]")).Click();

    }
}
