BlogPostManager
A simple ASP.NET Core project using Entity Framework Core for managing blogs, posts, tags, and drivers.

Features
Entity Framework Core setup with DbContext

Configured entity models for:

Blog

Post

Tags

Driver

Clean separation using IEntityTypeConfiguration<T> classes

Technologies Used
.NET Core

ASP.NET Core

Entity Framework Core

Getting Started
Prerequisites
.NET SDK

SQL Server or another EF Core-compatible database

Setup
Clone the repository:

bash
Copiar
Editar
git clone https://github.com/your-username/BlogPostManager.git
cd BlogPostManager
Update the appsettings.json with your connection string.

Apply migrations and update the database:

bash
Copiar
Editar
dotnet ef migrations add InitialCreate
dotnet ef database update
Run the application:

bash
Copiar
Editar
dotnet run
Folder Structure
Models/ – Contains the domain models (Blog, Post, Tags, Driver)

Data/ – EF Core DbContext and configurations

Configurations/ – EntityTypeConfiguration implementations for each model

Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.
