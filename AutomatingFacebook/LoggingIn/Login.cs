using AutomatingFacebook.NewFolder;
using OpenQA.Selenium;
using System;


namespace AutomatingFacebook.LoggingIn
{
    public class Login:DriverHelper
    {

        /*This particular class defines that we have to sign into the amazon portal and then enter the Email address and
         after clicking on Continue button we have to we have to enter the password and have to click on Sign in. This Class
        should automatically lets you get inside the Amazon portal*/ 


        //Email content
        public static void Email_logging(string content)
        {
            //Email Element in Sign in page
            IWebElement Email = Driver.FindElement(By.Id("ap_email"));
            Email.SendKeys(content);
        }

        //Clicking on Continue button
        public static void Continue_Button()
        {
            //Continue Element
            IWebElement Continue = Driver.FindElement(By.Id("continue"));
            Continue.Click();
        }

        //Enter Password
        public static void Password_logging(string passwrd)
        {
            //Password Element
            IWebElement Password = Driver.FindElement(By.Id("ap_password"));
            Password.SendKeys(passwrd);
        }

        //Clicking on Sign in
        public static void Signing_in_click()
        {
            //Sign in Element
         IWebElement Signingin = Driver.FindElement(By.Id("signInSubmit"));
            Signingin.Click();
        }
    }
}
