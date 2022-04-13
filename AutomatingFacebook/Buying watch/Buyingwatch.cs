using AutomatingFacebook.NewFolder;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;


namespace AutomatingFacebook.Buying_watch
{
    public class Buyingwatch : DriverHelper
    {
        /*After adding the particular product in the cart the software checks if the particular product is in the cart or not
         1. If the Product is in the cart then it will proceed to buy the product, else as of now it will return an error stating
        that the product is not in the cart*/

        public static void AddtoCart()
        {
            IWebElement Adddingtocart = Driver.FindElement(By.Id("add-to-cart-button"));
            Adddingtocart.Click();
        }

        public static void CheckInCart()
        {
            IWebElement Checkingincart = Driver.FindElement(By.Id("nav-cart-count"));
            Checkingincart.Click();
        }

        public static void findproduct()
        {
            String Quantity = "1";
            string productincart = "a-autoid-0-announce";
            IWebElement productinthecart = Driver.FindElement(By.Id(productincart));

            if (productincart != Quantity)
            {
                productinthecart.Click();
                IWebElement OneQuantity = Driver.FindElement(By.Id("quantity_1"));
                OneQuantity.Click();
            }
        }

        public static void ProceedtoBuyfromcart()
        {
            IWebElement ProceedtoBuy = Driver.FindElement(By.ClassName("a-button-input"));
            ProceedtoBuy.Click();
        }
    }
}
