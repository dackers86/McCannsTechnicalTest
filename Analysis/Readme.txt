-- API --

The proposed solution involves creating a web API using Nancy and self hosted by OWIN.


The routes provided are to be...

/customer   	GET
/customer?id=   GET
/customer       POST     
/customer?id=   UPDATE
/customer?id=   DELETE


-- Design Patterns -- 


To be as modular as possible the design patterns include the following...

Repository Pattern - To quickly switch between how the database is persisted.
Dependency Injection - To enable the whole solution to be modular and enable TDD.
Strategy Pattern - Introduced to help with the abstraction between Customers and their Account Types.


-- Database -- 

SQL (if required to import Legacy Database, merge with existing for future work)


-- Authentication -- 

Nancy like all APIs allows tokens to be passed through the headers. The solution will ideally contain a seperate authentication service / API that can take the token and return a status.

The token will be an encrypted key within the system using SALT to disguise the true key.
Future work will need an option to provide a user name and password connected to a database, this will return a key generated and stored for the user. Social Authentication would not be required.


-- Validation -- 

A seperate Flued Validation service will be needed to validate and bind the data provided.


-- Data Contract -- 

To ensure the data is in a JSON format, Nancy has built in functionality for returning the data in the correct format.