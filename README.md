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

## Some testings with Postman

* Query all products

![image](https://github.com/namphuong2217/Computacenter-Interview-Task/blob/main/Documentation/PostmanProducts.png)

* Login JWT

![image](https://github.com/namphuong2217/Computacenter-Interview-Task/blob/main/Documentation/PostmanToken.png)

* Query options wheels, varnish, accessory, engine 

![image](https://github.com/namphuong2217/Computacenter-Interview-Task/blob/main/Documentation/PostmanTypes.png)




