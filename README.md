# Movie API

This project is a Movie API built with ASP.NET Core (.NET 8) that provides endpoints for retrieving movie details, searching movies, and fetching popular movies. The API is secured with an API key system and uses an in-memory for testing and MS SQL database for data storage in runtime.

---

## Setup Instructions

1. **Clone the Repository**:
   
2. **Set Up Environment Variables**:
   - Create an environment variable for allowed API keys:
   - Replace `key1,key2,key3` with your actual API keys.

3. **Configure the Database**:
   - By default, the application uses an in-memory database for testing and development.
   - To use a SQL database, update the connection string in `appsettings.json`:
   - Register the database in `Program.cs`:

4. **Run the Application**:
   - Use the following command to start the application:
     
   - The API will be available at `https://localhost:5001` (or the configured port).

5. **Access Swagger UI**:
   - Navigate to `https://localhost:5001/swagger` to explore and test the API endpoints.

---

## API Key System

The API is secured using an API key middleware. Each request must include a valid API key as a query parameter (`api_key`). 

### How It Works:
1. The middleware reads the allowed API keys from the `ALLOWED_API_KEYS` environment variable.
2. Each incoming request is checked for the `api_key` query parameter.
3. If the API key is missing or invalid:
   - A `401 Unauthorized` response is returned if the key is missing.
   - A `403 Forbidden` response is returned if the key is invalid.

### Example:
To access the `GetMovieDetails` endpoint:
Replace `key1` with a valid API key.
---

## Database Schema

The database contains a single table for movies. Below is the schema:

### Movies Table:
| Column       | Type         | Description                     |
|--------------|--------------|---------------------------------|
| `Id`         | `Guid`       | Primary key.                   |
| `Title`      | `string`     | Title of the movie.            |
| `ReleaseDate`| `DateTime`   | Release date of the movie.     |
| `PosterUrl`  | `string`     | URL of the movie poster.       |
| `Overview`   | `string`     | Short description of the movie.|
| `Genres`     | `string`     | Comma-separated genres.        |
| `Rating`     | `int`        | Rating of the movie (1-10).    |
| `Runtime`    | `int?`       | Runtime in minutes (optional). |
| `Language`   | `string`     | Language of the movie.         |

---

## How to Test the API

### Integration Tests
1. **Run Integration Tests**:
   - Use the following command to run integration tests:
   - Integration tests are located in the `Tests` project and include tests for the `MoviesController` and `MovieService`.

2. **Test Data**:
   - The `TestDataSeeder` class seeds the in-memory database with test data during integration tests.

### Manual Testing
1. **Using Swagger**:
   - Navigate to `https://localhost:5001/swagger` to manually test the API endpoints.
   - Include the `api_key` query parameter in your requests.

2. **Using Postman**:
   - Import the API endpoints into Postman.
   - Add the `api_key` query parameter to each request.

### Example Requests
- **Get Movie Details**:
- **Search Movies**:
- **Get Popular Movies**:
  

---

## Notes
- Ensure the `ALLOWED_API_KEYS` environment variable is set before running the application or tests.
- For production, use a secure database and consider using a secret management tool (e.g., Azure Key Vault) for API keys.

Let me know if you need further assistance!
