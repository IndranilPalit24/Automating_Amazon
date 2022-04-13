using AutomatingFacebook.NewFolder;
using OpenQA.Selenium;
using System;


namespace AutomatingFacebook.FindWatches
{
    public class Findingwatches:DriverHelper
    {
        /* After you Login wiht your Username and Password this particular class focuses on the Relevance search(Main Search)
         bar on the top and automatically types the required product to find(here: watches) and then goes on the find the product
        .In this code the paticular product is preselected and it adds to cart*/ 
        public static void SearchBox(string yourchoice)
        {
            IWebElement findsearchbox = Driver.FindElement(By.Id("twotabsearchtextbox"));
            findsearchbox.SendKeys(yourchoice);
        }

        public static void ClickonSearchButton()
        {
            IWebElement clickSearchButton = Driver.FindElement(By.Id("nav-search-submit-button"));
            clickSearchButton.Click();
        }

        public static void findproduct(string product)
        {
            IWebElement productfound = Driver.FindElement(By.LinkText(product));
            productfound.Click();
        }


    }
}
