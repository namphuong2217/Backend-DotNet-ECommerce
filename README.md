# Computacenter Interview Tasks
![images](https://github.com/gothinkster/aspnetcore-realworld-example-app/blob/master/logo.png)

# Backend ASP .NET 5.0 Car Configurator

A backend REST services for a Car Configurator site.

## Overview

Project built with [ASP.NET Framework](https://dotnet.microsoft.com/apps/aspnet) from scratch.

Environment used:

* .NET 5.0
* VS Code
* Dotnet CLI, EF Migrations,


#### Database Schema

![images](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Documentation/Car%20Configurator%20Final.png)

#### Frontend Store Overview

![images](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Documentation/Store1.png)
![images](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Documentation/Store2.png)

#### API Endpoints and Data Models

![images](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Documentation/Swagger1.png)
![images](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Documentation/Swagger2.png)
![images](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Documentation/Swagger3.png)
![images](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Documentation/Swagger4.png)


## How it works

* API-Core-Infrastructure architecture

![images](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Documentation/ApplicationArchitecture1.png)

The application is built in 3 layer architecture: [API Project](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/API), [Core Project](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/Core), [Infrastructure Project](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/Infrastructure)

* Use Data Transfer Object to separate the read model data and write model data.

[DTOs](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/API/Dtos)

Code organized as follows:

1. [``API Project``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/API) responsible for [handlers/controllers](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/API/Controllers) for coming requests from client
2. [``Core Project``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/Core) responsible for entities/data models.
3. [``Infrastructure Project``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/Infrastructure) responsible for accessing database and processing data
4. [``Entities``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/Core/Entities), [``DTOs``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/API/Dtos)
5. [``Auto Mapper``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/API/Helpers/MappingProfiles.cs) map entities and DTOs
6. ``Repository Pattern`` decouple code from data access, minimize duplicate query logic 
[``IGenericRepository``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Core/Interfaces/IGenericRepository.cs)
[``GenericRepository``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Infrastructure/Data/GenericRepository.cs)
6. [``Specification Pattern``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/Core/Specifications) along with ``Repository Pattern`` to describe query in an object and implement advanced queries like OrderBy, Asc/Desc, Sorting on client's side
7. ``Unit Of Work pattern`` handles complex query involving more than one data table in database
[``UnitOfWork Interface``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Core/Interfaces/IUnitOfWork.cs)
[``UnitOfWork Implementation``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Infrastructure/Data/UnitOfWork.cs)
8. Use Redis in memory database to manage user basket/shopping cart functionality [``BasketController``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/API/Controllers/BasketController.cs), [``BasketRepository``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Infrastructure/Data/BasketRepository.cs)

## Security

Implement ``User Identity`` with ASPNET Framework user manager package [``AppUser``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/Core/Entities/Identity), [``UserManagerExtensions``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/API/Extensions/UserManagerExtensions.cs), [``AccountController``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/API/Controllers/AccountController.cs)


## Database

Currently use Sqlite for development

## Testing API with Postman

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

