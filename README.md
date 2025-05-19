#  Task Management API - ASP.NET Core (.NET 8)

This is a simple RESTful Web API built with ASP.NET Core for managing tasks. It supports all CRUD operations (Create, Read, Update, Delete) and uses an **in-memory database** for demonstration purposes.

---

##  Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- (Optional) Angular client or any frontend to consume the API (CORS enabled for `http://localhost:4200`)

---

##  How to Build and Run

1. **Clone the Repository**
 for API   git clone https://github.com/prathameshpailwan/Sdaemon_API_G.git

 for UI(optional)   git clone https://github.com/prathameshpailwan/Sdaemon_Task_UI.git
   

## steps which are followed
1] Initial project setup and dependencies

2] Created Task model and DbContext

3] Implemented TaskController with CRUD endpoints

4] Added Swagger and configured CORS

5] Final cleanup and documentation update

6] Tested the application using swagger as well as from UI also using angular application 



## Limitations:

Uses in-memory database: all data is lost on app restart.

No authentication/authorization implemented.

No input validation beyond title required.

No pagination or filtering in GET requests.

## Improvements (if more time was available):

Replace in-memory DB with SQL Server and add EF Core migrations.

Implement full model validation and error handling middleware.

Add authentication (e.g., JWT-based) and user roles.

Build a simple UI (Angular or React) to consume the API.

Add unit and integration tests using xUnit and Moq.

Add logging using Serilog or built-in ASP.NET logging.