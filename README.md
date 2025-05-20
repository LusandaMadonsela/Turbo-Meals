# Turbo-Meals
 This is an E-Commerce Restaurant System tailored to efficiently manage both online and in-store orders
 
Steps to on how to run TurboMeals
Different Users and their roles
RoleTypes:
1 - Admin
2 - Customer
3 - Driver
4 - Kitchen Staff
5 – POS

Step 1
Head over to the AccountController
- Under the Register method change the RoleType to create the different users for the system.
First set it to 1, to create the admin user. Run the app and register. Once registered those credentials will belong to the admin user.
Close the app and head back to the controller to create the next user… user 2, etc..
Repeat the process until you have a user for each RoleType.
Once you have them you can change the RoleType back to 2 which is the default value… the customer.

**Important
After Creating all 5 of your users go to “Find in Files(Ctrl+Shift+F)”
There you will look up RoleType1@gmail.com and replace that email with the email you used for the admin. Do this for RoleType4 as well… this is important as it will allow the emails to go through to the recipient.

**Also Remember to change the connection string in the webconfig file so that the data is stored in your database

Step 2
Log in as RoleType 4 user you created and head to the ingredients tab and start adding different ingredients that make up what you want to sell. Eg, for a burger, youll have patties, tomatoes, lettuce, pickles and onions, the ingredients will depend on what type of burger you are selling. It does not have to be a burger it could be any food.
After that, head over to the Supplier tab and create some suppliers. With each supplier you can choose which ingredients they supply from the ingredients you have already added previously.

Step 3
Log in as RoleType1 (Admin) user you created and head to the Categories tab to add a category, e.g. burgers, drinks, schwamas etc… 
After that move on to the Products tab and add a product and include the image of the product.

Step 4
Log in as RoleType2(Customer) and add an item to the cart and proceed to checkout.
After that you will log in to a sandbox paypal account to confirm you payment.
Once that is done wait for your order to be confirmed.

Step 5
Now log in as RoleType4(Kitchen) to confirm the order is ready. 
Remember to order ingredients if you are low on an ingredient you should receive an email to notify you.
Once the order is ready it will appear on the admin side RoleType1 automatically

Step 6
Log in as  the admin RoleType1 and assign a driver to make the delivery. A list of drivers will be on the dropdown(RoleType3 we created at the beginning) select a driver to make the delivery.

Step 7 
Now log in as the drive RoleType3 and you will see a list of orders assigned to the driver for delivery.
Select the start button. From there you can notify the customer that you have the order and give them an estimate of your arrival. 
The driver can also get a route to the address where they will make a delivery.
Once the driver reaches the address the customer will sign for their order to confirm the receival.

The status of the order is updated frequently throughout the whole process.
Head over to RoleType2 the customer under the Orders tab to see the status of each order you made.

Under Orders tab on RoleType2 you can see your previous orders and request a refund if you want.

Refunds require you to give a reason and send an image for approval from the admin RoleType1. You will be rewarded with Turbo Points which you can use for your next purchase if the admin approves your request.

Make sure to use emails you have access to for your users as there is a lot of communication that goes back and forth.

With the above, I have given you an idea of how the application works.
This is the main function basically, for a customer to create an order and have it delivered to them. There is a lot more to explore within the application. I will work on creating a video to showcase everything about the application when I have more time on my hands. In the meantime feel free to explore.
