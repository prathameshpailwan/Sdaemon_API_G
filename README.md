#  Task Management API - ASP.NET Core (.NET 8)

This is a simple RESTful Web API built with ASP.NET Core for managing tasks. It supports all CRUD operations (Create, Read, Update, Delete) and uses an **in-memory database** for demonstration purposes.

---

##  Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- (Optional) Angular client or any frontend to consume the API (CORS enabled for `http://localhost:4200`)

---

##  How to Build and Run

1. **Clone the Repository**
   ```bash
   git clone https://github.com/prathameshpailwan/Sdaemon_API_G.git
   

## steps which are followed
1] Initial project setup and dependencies

2] Created Task model and DbContext

3] Implemented TaskController with CRUD endpoints

4] Added Swagger and configured CORS

5] Final cleanup and documentation update

## shortcuts
1] In-Memory DB used for simplicity — replaceable with SQL Server or another provider.

2] Basic validation (e.g., title is required).

3] No authentication or user management.

4] CORS is configured for Angular development at http://localhost:4200.

5] tested via Swagger as well as  UI (using angular).