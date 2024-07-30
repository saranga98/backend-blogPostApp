# Blog Post Application Backend

This is the backend for the Blog Post Application, developed using .NET 8 and Entity Framework. The backend provides RESTful APIs for managing blog posts and handles image uploads. The database is SQL Server, and the application is deployed on Microsoft Azure.

## Features

- **CRUD Operations:** Create, read, update, and delete blog posts.
- **Image Upload:** Upload images for blog posts and manage them efficiently.
- **RESTful API:** Well-defined endpoints for interacting with the frontend.
- **Entity Framework:** ORM for seamless database interactions.

## Technologies Used

- **.NET 8:** Provides the core framework for the application.
- **Entity Framework:** Simplifies database interactions with an ORM.
- **SQL Server:** Reliable and scalable database for storing blog post data.
- **Microsoft Azure:** Hosting the backend and database for high availability.

## Getting Started

### Prerequisites

- .NET 8 SDK
- SQL Server
- Visual Studio or any other preferred IDE

### Installation

1. **Clone the repository:**

    ```bash
    git clone https://github.com/saranga98/blog-post-app-backend.git
    cd blog-post-app-backend
    ```

2. **Restore the packages:**

    ```bash
    dotnet restore
    ```

3. **Update the database connection string:**

    Open `appsettings.json` and update the `ConnectionStrings` section with your SQL Server details.

    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=your-server;Database=your-database;User Id=your-username;Password=your-password;"
    }
    ```

4. **Run the migrations and update the database:**

    ```bash
    dotnet ef database update
    ```

5. **Run the application:**

    ```bash
    dotnet run
    ```

The application will start and be accessible at `https://localhost:7185/`.
