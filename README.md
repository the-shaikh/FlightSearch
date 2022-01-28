# FlightSearch
The Project will need to be built and run through Visual Studio and request run from postman. 

The ValidateLogin request will validate the login and create a bearer token which is to be used to validate all the subsequent requests during that session.
Since there is only API, we need to run the ValidateLogin call and receive the bearer token. This token is to be then placed in the Authorization header of the request 
FlightSearch as parameter and schema as "Bearer". Due to time constraints the username and password have been hardcoded. In practical usage, the username and password 
will be validated and verified from the database. 

To run the request use the URL as baseURL/api/Account to call  the ValidateLogin request and baseURL/api/FlightSearch to call flightSearh. 
