# ASP.NET Core Repository Pattern Implementation

This repository demonstrates the implementation of the **Repository Pattern** and **Unit of Work** in an ASP.NET Core environment. The goal is to create a data access layer that is loosely coupled, easy to maintain, and highly testable.

## 🚀 Key Features
* **Generic Repository:** Reusable logic for standard CRUD operations. 
* **Unit of Work:** Ensures atomicity by managing multiple repository transactions. 
* **Dependency Injection:** Clean service registration and management. 
* **Separation of Concerns:** Distinct layers for Data Access, Logic, and API.  

## 🏗️ Project Architecture
The project follows a layered architecture to ensure a clean codebase:
1.  **Core/Domain:** Contains Entities and Interface definitions. 
2.  **Infrastructure:** Implements the Interfaces and DbContext using Entity Framework Core.
3.  **API/Web:** The entry point that consumes the services via Dependency Injection.


## 🛠️ Technologies Used
* .NET Core 
* Entity Framework Core
* LINQ


