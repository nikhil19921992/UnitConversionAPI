\# Unit Conversion API



\## Project Overview

This is a RESTful API built using ASP.NET Core that performs unit conversions between different measurement types such as length, weight, temperature, etc.



The project is designed with clean architecture principles using Controllers, Services, and Models to ensure separation of concerns and maintainability.



\---



\## Features

\- Convert between different units (e.g., meters to kilometers, grams to kilograms, etc.)

\- REST API architecture

\- Clean separation of business logic and API layer

\- Lightweight and fast execution

\- Easy to extend for new unit types



\---



\## Project Structure

UnitConversionAPI/

│── Controllers/ # API endpoints

│── Models/ # Request \& Response classes

│── Services/ # Business logic (conversion logic)

│── Properties/ # Launch settings

│── Program.cs # App entry point

│── appsettings.json # Configuration

│── UnitConversionAPI.csproj





\---



\## How to Run the Project Locally



\### 1. Clone the repository

```bash

git clone https://github.com/nikhil19921992/UnitConversionAPI.git   



2\. Navigate to project folder

</>Bash

cd UnitConversionAPI



3\. Restore dependencies

</>Bash

dotnet restore



4\. Build the project

</>Bash

dotnet build



5\. Run the project

</>Bash

dotnet run



6\. Open API in browser

https://localhost:5001/swagger

or

http://localhost:5000/swagger



**Design Decisions**

* Separation of Concerns

&#x20;  Business logic is separated into a Service layer to keep controllers clean.

&#x20;  Scalability

&#x20;  Easy to add new unit conversions without modifying existing logic heavily.

* Maintainability

&#x20;  Organized folder structure for better readability and future updates.

* REST Standards

&#x20;  Follows standard HTTP methods and response structure.



&#x20;**Trade-offs**

* No database integration (data is processed in memory only)
* No authentication or authorization layer
* Minimal validation implemented to keep focus on core functionality
* Swagger used for testing instead of custom UI



**API Example (if applicable)**

**Request**

</> JSON

{

&#x20; "category": "weight",

&#x20; "fromUnit": "kilogram",

&#x20; "toUnit": "pound",

&#x20; "value": 5

}



**Response**

**{**

&#x20; **"originalValue": 5,**

&#x20; **"fromUnit": "kilogram",**

&#x20; **"toUnit": "pound",**

&#x20; **"convertedValue": 11.0231**

**}**



**Tech Stack**

* ASP.NET Core Web API
* C#
* .NET 6/7+
* Swagger (for API testing)



**Author**

**Nikhil Chiniwal**

