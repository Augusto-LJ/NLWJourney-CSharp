# NLWJourney-CSharp

A C# backend application developed during the NLW (Next Level Week) Journey, focusing on building robust APIs with proper validation and testing mechanisms.

## 🧰 Technologies Used

- **C#**: Primary programming language.
- **.NET**: Framework for building the application.
- **SQLite**: Lightweight relational database.
- **xUnit**: Testing framework for unit tests.

## 🚀 Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.
- [Visual Studio](https://visualstudio.microsoft.com/) or any other preferred IDE.

### Installation

1. **Clone the repository:**
  ```bash
  git clone https://github.com/Augusto-LJ/NLWJourney-CSharp.git
  cd NLWJourney-CSharp
  ```
2. Restore dependencies:
  ```bash
  dotnet restore
  ```
3. Build the solution:
  ```bash
  dotnet build
  ```
4. Run the application:
  ```bash
  dotnet run --project src/
  ```

## 🧪 Running Tests
Navigate to the test project directory and execute the tests:
```bash
cd tests/Validators.Test
dotnet test
```

## 🗃️ Database
The application uses a SQLite database (JourneyDatabase.db). Ensure that the database file is present in the root directory. If not, you may need to set up the database schema and seed data as required.
  
