![images](https://github.com/gothinkster/aspnetcore-realworld-example-app/blob/master/logo.png)

# Computacenter Interview Tasks (70% complete)

A backend REST services for a Car Configurator site.

"Aufgabenstellung:
Sie wurden damit beauftragt einen Car-Konfigurator zu entwickeln, welcher die Konfiguration eines Autos mit den folgenden
Optionen ermöglicht:

* Motorleistung
* Lackierung
* Felgen
* Sonderausstattungen

Jede Veränderung an der Konfiguration soll sich unmittelbar und ohne Page-Refresh auf den angezeigten Preis auswirken. Am
Ende der Konfiguration soll eine Zusammenfassung angezeigt und die Bestellung abgesendet werden können. Zudem soll eine
URL generiert werden, mit dem der Benutzer jederzeit Zugriff auf die gewählte Konfiguration hat. Sowohl die
Konfigurationseigenschaften als auch die Bestellungen sind in einer Datenbank zu speichern."


## Overview

Project built with [ASP.NET Framework](https://dotnet.microsoft.com/apps/aspnet) from scratch.

Environment used:

* .NET 5.0
* VS Code
* Dotnet CLI, EF Migrations


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


Code organized as follows:

1. [``API Project``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/API) responsible for [handlers/controllers](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/API/Controllers) for coming requests from client
2. [``Core Project``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/Core) responsible for entities/data models.
3. [``Infrastructure Project``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/Infrastructure) responsible for accessing database and processing data
4. [``Entities``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/Core/Entities), [``DTOs``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/API/Dtos) separates the read model data and write model data
5. [``Auto Mapper``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/API/Helpers/MappingProfiles.cs) map entities and DTOs
6. ``Repository Pattern`` decouple code from data access, minimize duplicate query logic 
[``IGenericRepository``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Core/Interfaces/IGenericRepository.cs)
[``GenericRepository``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Infrastructure/Data/GenericRepository.cs)
6. [``Specification Pattern``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/Core/Specifications) along with ``Repository Pattern`` describe query in an object and implement advanced queries like OrderBy, Asc/Desc, Sorting on client's side
7. ``Unit Of Work pattern`` handles complex query involving more than one data table in database
[``UnitOfWork Interface``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Core/Interfaces/IUnitOfWork.cs), 
[``UnitOfWork Implementation``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Infrastructure/Data/UnitOfWork.cs)
8. Use Redis in memory database to manage user basket/shopping cart functionality [``BasketController``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/API/Controllers/BasketController.cs), [``BasketRepository``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/Infrastructure/Data/BasketRepository.cs), [``BasketItem``](https://github.com/namphuong2217/Computacenter-Interview-Task/blob/main/Core/Entities/BasketItem.cs), [``CustomerBasket``](https://github.com/namphuong2217/Computacenter-Interview-Task/blob/main/Core/Entities/CustomerBasket.cs)
9. Implemetation handles saving an order [``OrderAggregate``](https://github.com/namphuong2217/Computacenter-Interview-Task/tree/main/Core/Entities/OrderAggregate), [``OrderService``](https://github.com/namphuong2217/Computacenter-Interview-Task/blob/main/Infrastructure/Services/OrderService.cs), [``OrdersController``](https://github.com/namphuong2217/Computacenter-Interview-Task/blob/main/API/Controllers/OrdersController.cs)

## Security

Implement ``User Identity`` with ASP .NET Framework user manager package [``AppUser``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/tree/main/Core/Entities/Identity), [``UserManagerExtensions``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/API/Extensions/UserManagerExtensions.cs), [``AccountController``](https://github.com/namphuong2217/Backend-DotNet-ECommerce/blob/main/API/Controllers/AccountController.cs), [``TokeService for managing JWT``](https://github.com/namphuong2217/Computacenter-Interview-Task/blob/main/Infrastructure/Services/TokenService.cs)


## Database

Currently use Sqlite for development

## Some testings with Postman

* Query all products with pagination

![image](https://github.com/namphuong2217/Computacenter-Interview-Task/blob/main/Documentation/PostmanProducts.png)

* Login JWT

![image](https://github.com/namphuong2217/Computacenter-Interview-Task/blob/main/Documentation/PostmanToken.png)

* Query options wheels, varnish, accessory, engine 

![image](https://github.com/namphuong2217/Computacenter-Interview-Task/blob/main/Documentation/PostmanTypes.png)




