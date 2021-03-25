# GraphQL with EntityFramework and Postgres

## How to setup Postgres within Docker
    
 ### Install Postgres Nuget Driver

    dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
    dotnet add package Microsoft.EntityFrameworkCore.Design

Note: Microsoft.EntityFrameworkCore.Design is used for migrations

### Make sure to install or update to the latest dotnet ef tools

    dotnet tool install --global dotnet-ef \
    dotnet tool update --global dotnet-ef

### Add GraphQL
    dotnet add GraphQL package HotChocolate.AspNetCore

    dotnet add package GraphQL.Server.Ui.Voyager

 ### Add an initial migration
    dotnet ef migrations add "Initial" --context Context --verbose


### Add Automapper
    dotnet add package Automapper
    dotnet add package Automapper.Extensions.Microsoft.DependencyInjection

### Add HotChocolate
    dotnet add package HotChocolate.AspNetCore
    dotnet add package HotChocolate.Data.EntityFramework

Banana Cake Pop is available at: http://localhost:5002/graphql/ 
