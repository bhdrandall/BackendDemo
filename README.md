# BackendDemo

BackendDemo is a library management system built with ASP.NET Core and Entity Framework Core. This application allows users to manage books, genres, and user roles within a library context.

## Features

- **Book Management**: Add, update, delete, and view books in the library.
- **Genre Management**: Create and manage genres for categorizing books.
- **User Roles**: Define user roles to control access to certain features.
- **API Integration**: RESTful API for interacting with the library system.

## Technologies Used

- **ASP.NET Core**: For building the web application.
- **Entity Framework Core**: For database interactions.
- **SQL Server**: As the database management system.
- **Swashbuckle**: For generating Swagger documentation for the API.

## Getting Started

### Prerequisites

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/bhdrandall/BackendDemo.git
   cd BackendDemo
   ```

2. Restore the dependencies:
   ```bash
   dotnet restore
   ```

3. Update the database:
   ```bash
   dotnet ef database update
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
