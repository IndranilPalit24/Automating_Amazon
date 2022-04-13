using AutomatingFacebook.NewFolder;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AutomatingFacebook
{
    public class Tests: DriverHelper
    {
        [OneTimeSetUp]
        public void Setup()
        { 
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.amazon.in/ap/signin?openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.in%2F%3Fref_%3Dnav_ya_signin&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.assoc_handle=inflex&openid.mode=checkid_setup&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&");
            
        }


        [Test]
        public void ALoggingintoamazonportal()
        {
            //LoggingIn.Login.Signin(). This is for Logging inside the Amazon Website with your email and password.Here you will
            //enter your email.*/
            LoggingIn.Login.Email_logging("yourmemailhere");
            LoggingIn.Login.Continue_Button();
            
            /*Here you have to enter your password for the Amazon Account*/
            LoggingIn.Login.Password_logging("yourpassword here");
            LoggingIn.Login.Signing_in_click();
        }
        
        [Test]
        public void Bfindtheproduct()
        {
            Thread.Sleep(5000);
            /*You have to enter the choice of the product that you want to find*/
            FindWatches.Findingwatches.SearchBox("Your product here");
            FindWatches.Findingwatches.ClickonSearchButton();
            
            
            /*Select the product that you want to buy or search from a particular plethora of products*/
            FindWatches.Findingwatches.findproduct("Your product here");
            Thread.Sleep(5000);

        }

        [Test]
        public void CCheckoutPage()
        {
            /*This List described here say that if we have a two to three tabs opened in the Amazon webste you can jump from one tab to
             another in chrome*/ 
            List<string> handles = new List<string>();
            handles = Driver.WindowHandles.ToList();
    
            Driver.SwitchTo().Window(handles[1]); 
            
            Thread.Sleep(10000);
            Buying_watch.Buyingwatch.AddtoCart();
            Thread.Sleep(10000);
            Buying_watch.Buyingwatch.CheckInCart();
            Thread.Sleep(10000);
            Buying_watch.Buyingwatch.findproduct();
            Thread.Sleep(10000);
            Buying_watch.Buyingwatch.ProceedtoBuyfromcart();

        }

    
        [OneTimeTearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}