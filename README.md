## Events Platform

The overarching goal of this application was to build an [eventbrite](http://eventbrite.com) like web site. The main focus was developing and deploying back-end containerized microservices with ASP.NET Core. The microservices developed are as follows:

### Web MVC Microservice

This service utilizes a Model-View-Controller architecture to interact with the other microservices to present an interactive website for the user. This service also incorporates Stripe to process and accept user's payments following completion of an order. 

### Catalog Microservice

This service utilizes Microsoft SQL Server through the use of Entity Framework Core to store and retrieve event product information. This services also utilizes Swagger to generate API documentation. 

### Token Microservice

This service allows for incorporatation of the IdentityService4 OpenID Connect and OAuth 2.0 framework in web, cart, and order microservices to allow for sign-in authentication and authorizations.

### Cart Microservice

This service utilizes Redis for the storage of items in the user's cart.

### Order Microservice

This service utilizes Microsoft SQL Server through the use of Entity Framework Core to store and retrieve event product orders. 


### User Interface

The web MVC microservice serves the home page view after retrieving the available event products from the catalog microservice. Event products can be filtered by event organizer or event type: 

![Image](https://github.com/harveyx22/Events-Platform/blob/master/ScreenShots/Home%20Page%201.png?raw=true "Home Page 1")
![Image](https://github.com/harveyx22/Events-Platform/blob/master/ScreenShots/Home%20Page%202.png?raw=true "Home Page 2")
![Image](https://github.com/harveyx22/Events-Platform/blob/master/ScreenShots/Home%20Page%20Filtered.png?raw=true "Filtered Home Page")



After attempting to add an event product to the cart or clicking the log in button, the web MVC microservice redirects the user the log in page for authentication via the token microservice.

![Image](https://github.com/harveyx22/Events-Platform/blob/master/ScreenShots/Log%20In%20Page.png?raw=true "Log In Page")



Following authentication, the user can add multiple event products to their cart which will be stored through the cart microservice. The user can view the cart items on a separate page prior to ordering. 

![Image](https://github.com/harveyx22/Events-Platform/blob/master/ScreenShots/Logged%20In%20With%20Items%20In%20Cart.png?raw=true "Items In Cart Home Page")
![Image](https://github.com/harveyx22/Events-Platform/blob/master/ScreenShots/Cart%20Page.png?raw=true "Cart Page")



When the user commits to making an order, the web MVC microservice redirects to the order page where Stripe integration will accept the user's credit card information for processing of payment. Following completion of the order and storage of the order via the order microservice, the user is redirected to an order complete page where a unique order number is given.

![Image](https://github.com/harveyx22/Events-Platform/blob/master/ScreenShots/Order%20Page.png?raw=true "Order Page")
![Image](https://github.com/harveyx22/Events-Platform/blob/master/ScreenShots/Order%20Complete%20Page.png?raw=true "Order Complete Page")

