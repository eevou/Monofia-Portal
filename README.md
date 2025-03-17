# Monofia Portal

Monofia Portal is a .NET 8 based application designed to manage and display news articles with translations. The project is structured into several components, each serving a specific purpose within the application.

## Project Structure

- **Monofia Portal.Core**: Contains the core entities, interfaces, and specifications.
- **Monofia Portal.Services**: Provides services and data transfer objects (DTOs) for the application.
- **Monofia Portal.Infrastructure**: Handles data persistence, configurations, and data seeding.
- **Monofia Portal.APIs**: Exposes the application's functionality through RESTful APIs.

## Features

- Manage news articles and their translations.
- RESTful API endpoints for CRUD operations on news articles.
- Data seeding for initial setup.
- AutoMapper integration for object mapping.
- Entity Framework Core for data access.

## Installation

1. Clone the repository:
2. Navigate to the project directory:
3.  Restore the dependencies:


## Usage

1. Update the database connection string in `appsettings.json`:
   2. Apply migrations and seed the database:

   3. Run the application:

   
## API Endpoints

- `GET /api/news`: Retrieve all news articles.
- `GET /api/news/{id}`: Retrieve a specific news article by ID.
- `POST /api/news`: Create a new news article.
- `PUT /api/news/{id}`: Update an existing news article.
- `DELETE /api/news/{id}`: Delete a news article.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any changes.

## License

This project is licensed under the MIT License.

   
   
