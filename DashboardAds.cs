using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

[TestFixture]
public class DashboardAds
{
    private IWebDriver _driver;

    public DashboardAds()
    {
        FirefoxOptions options = new FirefoxOptions();
        options.AddArgument("disable-infobars");
        options.AddArguments("--start-maximized");
        _driver = new FirefoxDriver(options);
        _driver.Url = "http://junkmail.co.za/login";
//        _driver.Url = "http://junkmail.dsdemo.co.za/login";
        System.Threading.Thread.Sleep(5000);
    }

    [Test, Order(1)]
    public void Login()
    {
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.Name("Email")).SendKeys("junkmaildev@gmail.com");
        _driver.FindElement(By.Name("Password")).SendKeys("Tmp@@123");
        _driver.FindElement(By.Id("btnLogin")).Click();
        System.Threading.Thread.Sleep(5000);
    }

    [Test, Order(2)]
    public void DeactivateAd()
    {
        _driver.FindElement(By.CssSelector("[class='iv']")).Click();
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.CssSelector("[class='label label-success']"));
        _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='play_circle_outline'])[2]/following::i[1]")).Click();
        _driver.FindElement(By.CssSelector("[class='label label-danger']"));
    }

   // [Test, Order(3)]
    public void ActivateAds (){
        _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='play_circle_outline'])[2]/following::i[1]")).Click();
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.CssSelector("[class='label label-success']"));
    }

    [Test, Order(3)]
    public void EditAd()
    {

     //   _driver.Navigate().Refresh();
        _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='edit'])[1]/following::i[1]")).Click();
        System.Threading.Thread.Sleep(5000);
        _driver.FindElement(By.CssSelector("[class='post-advert']")).Click();
    }

    public void test() { 

            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Inactive'])[1]/following::i[1]")).Click();
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='power_settings_new'])[2]/following::i[1]")).Click();
            Assert.AreEqual("Place a Free Ad | Junk Mail", _driver.Title);
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Search'])[1]/following::div[2]")).Click();
            _driver.FindElement(By.Id("Description")).Click();
            _driver.FindElement(By.Id("Description")).Click();
            String var1 = _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Jobs'])[2]/preceding::h4[1]")).Text;
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='power_settings_new'])[2]/following::i[1]")).Click();
    
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='autorenew'])[1]/following::i[1]")).Click();
 //           Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete We are hiring Avon represantatives[\\s\\S]$"));
            _driver.FindElement(By.LinkText("Inactive Ads31")).Click();
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='bzwhdmy'])[1]/following::div[2]")).Click();
            Assert.AreEqual("Inactive", _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='For Sale'])[1]/following::div[1]")).Text);
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='power_settings_new'])[2]/following::i[1]")).Click();
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='edit'])[1]/following::i[1]")).Click();
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Save changes'])[1]/following::i[1]")).Click();
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='edit'])[1]/following::i[1]")).Click();
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Save changes'])[1]/following::i[1]")).Click();
            _driver.FindElement(By.LinkText("Inactive Ads31")).Click();
            _driver.FindElement(By.LinkText("Pending Ads0")).Click();
            _driver.FindElement(By.LinkText("Archived Ads52")).Click();
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Leisure'])[2]/preceding::h4[1]")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_1 | ]]
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Refine Search'])[1]/following::div[5]")).Click();
            Assert.AreEqual("This item has been sold", _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Refine Search'])[1]/following::div[5]")).Text);
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='All Ads'])[1]/preceding::a[1]")).Click();
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Inactive'])[2]/following::input[1]")).Click();

            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='refresh'])[1]/following::i[1]")).Click();
         //   Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 Listings[\\s\\S]$"));

            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='autorenew'])[3]/following::i[1]")).Click();
    //        Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete Another altimate test[\\s\\S]$"));
            _driver.FindElement(By.Id("txtSearch")).Click();
            _driver.FindElement(By.Id("txtSearch")).Clear();
            _driver.FindElement(By.Id("txtSearch")).SendKeys("we are hiring");
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Promote Ads'])[1]/following::span[2]")).Click();
            Assert.AreEqual("We are hiring Avon represantatives", _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Jobs'])[2]/preceding::h4[1]")).Text);
            _driver.FindElement(By.LinkText("Get Auto Repeat")).Click();
          //  try
          //  {
           //     Assert.AreEqual("Auto Repeat", _driver.Title);
         //   }
          //  catch (AssertionException e)
         //   {

         //   }
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Get Auto Repeat'])[1]/following::button[1]")).Click();
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Save changes'])[1]/following::i[1]")).Click();
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Get Auto Repeat'])[1]/following::button[1]")).Click();
            _driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Save changes'])[1]/following::i[1]")).Click();
            _driver.FindElement(By.LinkText("Promote Ads")).Click();
            Assert.AreEqual("Promote Ads", _driver.Title);
        }
 
    }
