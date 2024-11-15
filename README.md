# ASP.NET Core MVC CRUD Operations with Entity Framework Core and Image Upload

This project demonstrates how to perform CRUD (Create, Read, Update, Delete) operations in an ASP.NET Core MVC application using Entity Framework Core with a SQL Server database. Additionally, it includes functionality to upload and manage images.

## Table of Contents

- [Prerequisites](#prerequisites)
- [Setup and Configuration](#setup-and-configuration)
- [Database Connection](#database-connection)
- [CRUD Operations](#crud-operations)
- [Image Upload](#image-upload)
- [Running the Application](#running-the-application)

---

## Prerequisites

Before getting started, ensure you have the following installed:

1. [.NET Core SDK](https://dotnet.microsoft.com/download)
2. [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
3. [Visual Studio](https://visualstudio.microsoft.com/) or any IDE of your choice
4. [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)

---

## Setup and Configuration

1. **Create ASP.NET Core MVC Project**:
   - Open Visual Studio and create a new project.
   - Select **ASP.NET Core Web Application**.
   - Choose the **Model-View-Controller (MVC)** template.

2. **Add Entity Framework Core**:
   Run the following commands in the Package Manager Console:
   ```bash
   Install-Package Microsoft.EntityFrameworkCore
   Install-Package Microsoft.EntityFrameworkCore.SqlServer
   Install-Package Microsoft.EntityFrameworkCore.Tools




