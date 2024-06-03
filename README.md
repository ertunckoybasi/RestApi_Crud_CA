# Clean Architecture - CRUD Project

This project is a CRUD application built using Clean Architecture, Repository Pattern, MediatR, Fluent Validation, Entity Framework Core, and Unit of Work. The project also includes a bulk delete feature.

## Features

- **Modular structure with Clean Architecture principles**
- **CRUD operations**
- **Bulk delete feature**
- **Data access layer with Repository Pattern**
- **CQRS and Mediation with MediatR**
- **Strong validation rules with Fluent Validation**
- **Database operations with Entity Framework Core**
- **Transaction management with Unit of Work**

## Requirements

- .NET 8 SDK
- SQL Server (or a compatible database)

## Getting Started

### Prerequisites

Make sure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation


    ```

1. Update the database connection string in `appsettings.json`:

    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
    }
    ```

2. Apply the database migrations:

    ```bash
    dotnet ef database update
    ```

3 Run the application:

    ```bash
    dotnet run
    ```

## Project Structure

- **Domain**: Contains the core entities, interfaces, and domain logic.
- **Application**: Contains the business logic, including CQRS handlers, validators, and DTOs.
- **Infrastructure**: Contains the data access implementation, including repositories and Entity Framework context.
- **API**: Contains the ASP.NET Core Web API controllers and configuration.

## Usage

### CRUD Operations

The application supports standard CRUD operations:

- **Create**: Add new entities.
- **Read**: Retrieve entities.
- **Update**: Modify existing entities.
- **Delete**: Remove entities.

### Bulk Delete Feature

The bulk delete feature allows for the deletion of multiple entities in a single operation.

## Technologies Used

- **Clean Architecture**: Ensures a modular and maintainable codebase.
- **Repository Pattern**: Provides a data access layer abstraction.
- **MediatR**: Implements CQRS and mediation.
- **Fluent Validation**: Enforces strong validation rules.
- **Entity Framework Core**: Handles database operations.
- **Unit of Work**: Manages transactions.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Acknowledgements

Inspired by the principles of Clean Architecture and various open-source projects.
