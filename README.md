# GraphQL with EntityFramework and Postgres

How to setup Postgres within Docker


**How to setup the project:**
    
- Install Postgres Nuget Driver

    dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL

    dotnet add package Microsoft.EntityFrameworkCore.Design

Make sure to install or update to the latest dotnet ef tools

dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef

Add GraphQL
- dotnet add GraphQL package HotChocolate.AspNetCore

Add an initial migration
- dotnet ef migrations add "Initial" --context Context --verbose


Add Automapper
- dotnet add package Automapper
- dotnet add package Automapper.Extensions.Microsoft.DependencyInjection

