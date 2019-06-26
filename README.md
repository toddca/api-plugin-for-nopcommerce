# API plugin for nopCommerce

This plugin provides a RESTful API for managing resources in nopCommerce.

## What is a RESTful API?


HTTP requests are often the way that you interact with a RESTful API.
A client makes an HTTP request to a server and the server responds with an HTTP response.

In a HTTP request, you need to define the type of action that you want to perform against a resource. There are four primary actions associated with any HTTP request (commonly referred to as CRUD):

**POST** (Create)

**GET** (Retrieve)

**PUT** (Update)

**DELETE** (Delete)

A resource is a data object that can be accessed via an HTTP request. The API allows you to “access your nopCommerce site’s data (resources) through an easy-to-use HTTP REST API”. In the case of the most recent version of the API (nopCommerce version 3.80), the resources include the following 7 nopCommerce objects:

[**Customers**](Customers.md)

[**Products**](Products.md)

[**Categories**](Categories.md)

[**ProductCategoryMappings**](ProductCategoryMappings.md)

[**Orders**](Orders.md)

[**OrderItems**](OrderItems.md)

[**ShoppingCartItems**](ShoppingCartItems.md)

With the nopCommerce API, you can perform any of the four CRUD actions against any of your nopCommerce site’s resources listed above. For example, you can use the API to create a product, retrieve a product, update a product or delete a product associated with your nopCommerce website.

## Configuration
A couple of configuration variables have been moved into appsettings.json. Once you are ready to deploy this solution it is recommended to add the following to your appsettings.json and generate a unique SecurityKey. 
 
 "Api": {
    "AllowedClockSkewInMinutes": 5,
    "SecurityKey": "please-generate-some-string"
  }

Please note, these settings are defaulted to good/valid values to quickly enable development. 
  
  
## Security
The API plugin for 4.2 now uses a custom nopCommerce role, basic auth and a JWT token for auth. 

## Getting Started

1. Uninstall any previous API plugin based on this or source project.
2. Build and Install this plugin.
3. Optional: Make config changes to appsettings.json as mentioned in the "Configuration" section of this document.
4. Add any user whom should have API access to the "Api Users" role. Any user in this role has permissions to access the API. 
5. Make a POST request to generate an access token which will be used to access the API. The token generation service is at /token. Example: POST: {your_server_name}/token?username={email_address}&password={password}
6. If the user's credentials are correct you will recieve an access_token in the response from calling POST /token which you will use is subsequent requests to the NopCommerce API.
7. Once you have an access token submit it via Bearer token request. By default the token does not have an expiry.









