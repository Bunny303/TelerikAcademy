Develop an application to store places of interest:
 - Each place has coordinates, name, a set of categories and optional description
 - Every user can leave a comment or vote for a place
	The user needs to type in their username
	No user authentication required
 - Categories have a name and set of places

1. Create a database for the application 
i.e. using MS SQL Server
Create tables, relations, schema, etc…
Create store procedures and indexes
Create everything needed for an app database

2. The data layer
The data layer contains a way to connect to the database
Entity Framework
Database-first or Code-first
ADO.NET
LINQ-to-SQL
LINQ-to-XML
Etc…

3.The Repositories Layer
The repository layer exposes repositories to work with the Database
Using the Repository Pattern
The repositories introduce methods to perform CRUD operations over the data store
In our case over the Places database

4. The Services Layer
The Services layer is the layer that contains the business logic
It uses the repositories for data interactions
Yet has no direct dependency over the data store
The Services layer contains all the controllers that are used by the Service Consumer
Handles computing and error handling
