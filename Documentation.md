# Automating_Amazon
This Code is about automating the amazon website to add a product in the cart and proceed to checkout page

Description:
You find a product and proceed to buy to checkout. This code is not getting to proceed to checkout, and buy the item for you as of now


Documentation:

Logging in the Website:
 
         This particular class defines that we have to sign into the amazon portal and then enter the Email address and
         after clicking on Continue button we have to we have to enter the password and have to click on Sign in. This Class
        should automatically lets you get inside the Amazon portal
        
        //Email content
         //Clicking on Continue button
          //Enter Password
          //Clicking on Sign in
          
 Finding Product:
         After you Login with your Username and Password this particular class focuses on the Relevance search(Main Search)
         bar on the top and automatically types the required product to find(here: watches) and then goes on the find the product
        .In this code the paticular product is preselected and it adds to cart
        
        //Search Box
        //ClickonSearchBox
        //FindProduct
        
Buying Product
          After adding the particular product in the cart the software checks if the particular product is in the cart or not
         1. If the Product is in the cart then it will proceed to buy the product, else as of now it will return an error stating
        that the product is not in the cart
        
        //Addtocart
        //CheckinCart
        //FindProduct
       //ProceedtoBuyfromCart
