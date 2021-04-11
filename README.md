# Computacenter Interview Tasks
![images](https://github.com/gothinkster/aspnetcore-realworld-example-app/blob/master/logo.png)

# Backend ASP .NET 5.0 Car Configurator

A backend REST services for a Car Configurator site.

## Overview

Project built with [ASP.NET Framework](https://dotnet.microsoft.com/apps/aspnet) from scratch.

Environment used:

* .NET 5.0
* VS Code

#### Database Schema

![images](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Documentation/Car%20Configurator%20Final.png)

#### Frontend Store Overview

![images](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Documentation/Store1.png)
![images](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Documentation/Store2.png)

#### API Endpoints and Data Models

![images](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Documentation/Swagger1.png)
![images](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Documentation/Swagger2.png)
![images](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Documentation/Swagger3.png
![images](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Documentation/Swagger4.png)


## How it works

The application uses Spring boot (Web, JPA, Postgresql, Lombok)

* Use the idea of Three-Layer Architecture Design to separate the business term and infrastruture term

The application is built in 3 layer architecture: [Controller Layer](https://github.com/namphuong2217/Social-Blogging-Platform/tree/main/src/main/java/com/personalproject/socialbloggingplatform/controller), [Service Layer](https://github.com/namphuong2217/Social-Blogging-Platform/tree/main/src/main/java/com/personalproject/socialbloggingplatform/service), [Repository Layer](https://github.com/namphuong2217/Social-Blogging-Platform/tree/main/src/main/java/com/personalproject/socialbloggingplatform/repository)

* Use JPA to implement the Data Mapper pattern for persistence to database.

* Use Data Transfer Object to separate the read model data and write model data.

Code organized as follows:

1. [``Controller Layer``](https://github.com/namphuong2217/Social-Blogging-Platform/tree/main/src/main/java/com/personalproject/socialbloggingplatform/controller) responsible handlers for coming requests from client
2. [``Service Layer``](https://github.com/namphuong2217/Social-Blogging-Platform/tree/main/src/main/java/com/personalproject/socialbloggingplatform/service) is the business/logic layers
3. [``Repository Layer``](https://github.com/namphuong2217/Social-Blogging-Platform/tree/main/src/main/java/com/personalproject/socialbloggingplatform/repository) is the Persistence/Data Access Layer
4. [``model``](https://github.com/namphuong2217/Social-Blogging-Platform/tree/main/src/main/java/com/personalproject/socialbloggingplatform/model), [``dto``](https://github.com/namphuong2217/Social-Blogging-Platform/tree/main/src/main/java/com/personalproject/socialbloggingplatform/dto) are the business models including entities and DTOs

6. [``exception``](https://github.com/namphuong2217/Social-Blogging-Platform/tree/main/src/main/java/com/personalproject/socialbloggingplatform/exception) is global custom exception to handle input invalidation, other exceptions and default exception handling.

## Security

Integration with Spring Security and add other filter for JWT token process.

The secret key is stored in application.properties.

[``security``](https://github.com/namphuong2217/Social-Blogging-Platform/tree/main/src/main/java/com/personalproject/socialbloggingplatform/security), [``config``](https://github.com/namphuong2217/Social-Blogging-Platform/tree/main/src/main/java/com/personalproject/socialbloggingplatform/config) handle security of API Endpoints

## Database

Use Postgresql database, can be changed easily in the [``application.properties``](https://github.com/namphuong2217/Social-Blogging-Platform/blob/main/src/main/resources/application.properties) for any other database.

## Testing API - Demo Client with [Insomnia](https://insomnia.rest/)

* API Request Collection

![image](https://github.com/namphuong2217/Social-Blogging/blob/main/documentation/000%20API%20Collection.png)

* Register a new user

![image](https://github.com/namphuong2217/Social-Blogging/blob/main/documentation/001%20Register.png)

* Global custom exception to handle invalidation [ExceptionHandler ``@ControllerAdvice``](https://github.com/namphuong2217/Social-Blogging-Platform/tree/main/src/main/java/com/personalproject/socialbloggingplatform/exception)

* Mail has already been registered

![image](https://github.com/namphuong2217/Social-Blogging-Platform/blob/main/documentation/001%20Not%20unique%20mail.png)

* Username is empty

![image](https://github.com/namphuong2217/Social-Blogging-Platform/blob/main/documentation/001%20Register%20Request%20name%20empty.png)

* Login of existing user 

![image](https://github.com/namphuong2217/Social-Blogging/blob/main/documentation/002%20Login.png)

* Create new community to group/categorize posts

![image](https://github.com/namphuong2217/Social-Blogging/blob/main/documentation/003%20Create%20Community.png)

* Query a community

![image](https://github.com/namphuong2217/Social-Blogging/blob/main/documentation/003%20Query%20A%20Community.png)

* Query all communities

![image](https://github.com/namphuong2217/Social-Blogging/blob/main/documentation/004%20Query%20All%20Communities.png)

* Create new post by current user

![image](https://github.com/namphuong2217/Social-Blogging/blob/main/documentation/004%20Create%20a%20post.png)

* Query all posts

![image](https://github.com/namphuong2217/Social-Blogging/blob/main/documentation/006%20Query%20All%20Posts.png)

* Create new comment by current user on specified post

![image](https://github.com/namphuong2217/Social-Blogging/blob/main/documentation/007%20Create%20A%20Comment.png)

* Query all comments by given username

![image](https://github.com/namphuong2217/Social-Blogging/blob/main/documentation/007%20Query%20Comment%20by%20Username.png)

* Downvote or Upvote a post

![image](https://github.com/namphuong2217/Social-Blogging/blob/main/documentation/008%20Vote%20A%20Post.png)

![image](https://github.com/namphuong2217/Social-Blogging/blob/main/documentation/008%20Vote%20A%20Post%20Query%20Post.png)

* Refresh Token

![image](https://github.com/namphuong2217/Social-Blogging/blob/main/documentation/009%20Refresh%20TOken.png)

* Logout and delete Refresh Token

![image](https://github.com/namphuong2217/Social-Blogging/blob/main/documentation/009%20Logout%20RefreshToken%20deleted.png)

## Modules, libraries and features

#### Spring Boot Starters
Bootstrap initial application

#### Spring Security
* Security of API Endpoints. Implementation of authentication/ authorization/login/logout with JSON Web Token and Spring Security, 
* Adding new user

#### Spring Data JPA with Postgresql
Persistence to Postgresql database using JPA. More control with [data.sql](https://github.com/namphuong2217/Social-Blogging-Platform/blob/main/src/main/resources/data.sql) and [schema.sql](https://github.com/namphuong2217/Social-Blogging-Platform/blob/main/src/main/resources/schema.sql)

#### Spring MVC
Dispatch requests to responsible handlers

#### JPA/Hibernate
Data persistence and management of entities and tables for application and database

#### CRUD 
Implement CREATE, READ, UPDATE, DELETE operations for RESTful services.

#### JSON Web Token 
Authenticate users

#### Lombok
Manage boiler-plate code in Java

#### MapStruct (unfinished)
Mapping entities to data transfer objects (DTO)

#### Mailtrap (unfinished)
Fake [SMTP server](https://mailtrap.io/) for managing sending/receiving mail for registration

#### Java Mail Sender (unfinished)
Send mail from the application

#### Swagger (unfinished)
Build API documentation

#### OAuth2 (unfinished)

## Running the project

[API documentation](https://backend-reddit-heroku.herokuapp.com/swagger-ui.html)(deprecated)

## Some Demos

* Postgresql database

![SQL](https://github.com/namphuong2217/Social-Blogging-Platform/blob/main/documentation/011%20SQL%20Pgadmin%201.png)

![SQL](https://github.com/namphuong2217/Social-Blogging-Platform/blob/main/documentation/011%20SQL%20Pgadmin.png)

* Data transfer objects

![DTO](https://github.com/namphuong2217/Backend-JavaSpring-Reddit/blob/main/src/main/resources/images/Screenshot%20from%202020-11-13%2009-51-13.png)

* API Endpoints

![Endpoints](https://github.com/namphuong2217/Social-Blogging-Platform/blob/main/documentation/010%20API%20Endpoints.png)
