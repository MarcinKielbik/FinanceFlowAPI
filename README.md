# FinanceFlowAPI

FinanceFlowAPI is a financial management application designed to help users track their budgets and expenses efficiently. This API provides endpoints for managing user authentication, budgeting, expense tracking, and categorization.

## Features
- **User Authentication**: Secure login and registration using JWT authentication.
- **Role-based Access Control**: Supports user roles with different access levels.
- **Budget Management**: Create, update, and delete budgets.
- **Expense Tracking**: Record expenses and categorize them.
- **Category Management**: Manage spending categories for better financial insights.
- **Swagger Documentation**: Interactive API documentation for easy testing.

## Tech Stack
- **.NET 8**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **SQL Server**
- **JWT Authentication**
- **Identity Framework**
- **Swagger for API documentation**

## Getting Started
### Prerequisites
- .NET 8 SDK
- SQL Server

### Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/FinanceFlowAPI.git
   cd FinanceFlowAPI
   ```
2. Configure the database connection in `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=your_server;Database=FinanceFlowDB;Trusted_Connection=True;"
   }
   ```
3. Run database migrations:
   ```sh
   dotnet ef database update
   ```
4. Run the application:
   ```sh
   dotnet run
   ```
5. Access Swagger documentation at:
   ```
   https://localhost:5001/swagger
   ```

## API Endpoints
| Method | Endpoint | Description |
|--------|---------|-------------|
| POST | `/api/auth/register` | Register a new user |
| POST | `/api/auth/login` | Authenticate and receive a JWT token |
| GET | `/api/budgets` | Get all budgets |
| POST | `/api/budgets` | Create a new budget |
| GET | `/api/expenses` | Get all expenses |
| POST | `/api/expenses` | Create a new expense |

## Contributing
Feel free to fork this repository and submit pull requests!

## License
This project is licensed under the MIT License.
