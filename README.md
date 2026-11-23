# 💻 LapMart — Laptop Shop Management System

A role-based desktop application for managing the day-to-day operations of a laptop retail and service shop. Built with **C# Windows Forms** and **Microsoft SQL Server** as an Object-Oriented Programming 2 course project at AIUB.

---

## 📋 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Database Schema](#database-schema)
- [Prerequisites](#prerequisites)
- [Installation & Setup](#installation--setup)
- [Usage Guide](#usage-guide)
- [Project Structure](#project-structure)

---

## Overview

LapMart solves the problem of manual, error-prone record-keeping in a laptop retail environment by providing a unified digital system for sales, inventory, employee management, and after-sales repair services.

The system supports **four distinct user roles**, each with their own dashboard and permissions:

| Role | Responsibilities |
|---|---|
| **Manager (Admin)** | Full system control — employees, inventory, sales reports |
| **Seller** | Customer sales, cart management, transaction history |
| **Service Executive** | Warranty checks, repair ticket creation, technician assignment |
| **Technician** | View assigned jobs, update repair status and progress |

All roles authenticate through a shared login screen and are redirected to their role-specific dashboard automatically.

---

## Features

### 🔑 Manager / Admin
- Add, edit, and delete employee accounts with role assignment
- Manage product inventory (add/edit/delete models, brands, specs, pricing, stock)
- View daily sales logs filtered by month and year
- Generate monthly and yearly sales reports
- Track year-over-year sales increment/decrement

### 🛒 Seller
- Browse and search available inventory
- Add products to cart with automatic subtotal calculation
- Register new customers and edit customer details
- Confirm and complete purchase transactions
- View personal transaction history

### 🔧 Service Executive
- Verify warranty eligibility based on purchase history
- Create repair orders and assign to technicians
- Register third-party (non-purchase) repair requests with cost estimation
- View list of pending and completed repairs with revenue summary

### 🛠️ Technician
- View service jobs assigned specifically to the logged-in technician
- Update repair status: **In Progress**, **Completed**, or **Not Fixable**
- Completion date is recorded automatically on status update

---

## Technologies Used

| Technology | Purpose |
|---|---|
| **C# (.NET Framework 4.8)** | Application logic and UI |
| **Windows Forms (WinForms)** | Graphical desktop interface |
| **Microsoft SQL Server Express** | Relational database backend |
| `System.Data.SqlClient` | ADO.NET database connectivity |
| **Visual Studio 2022** | IDE |

---

## Database Schema

The database is named `LapMart` and uses the following normalized tables:

```
Products        → ProductID (PK), ProductName, Brand, Model, Specification,
                  UnitPrice, QuantityInStock, Warranty, CategoryID (FK), SupplierID (FK)

Category        → CategoryID (PK), CategoryName

Sales           → SaleID (PK), SaleDate, TotalAmount, CustomerID (FK), UserID (FK)

SaleDetails     → SaleDetailsID (PK), SaleID (FK), ProductID (FK),
                  Quantity, UnitPrice, Subtotal

Customers       → CustomerID (PK), FullName, Address, Email, Phone

Users           → UserID (PK), UserName, Password, FullName, Role, Phone, Address

Repairs         → RepairID (PK), CustomerID (FK), TechnicianID (FK), ProductID (FK),
                  ProblemDescription, Cost, CreatedAt, CompletedAt
```

The connection string in `DataAccess.cs` targets a local SQL Server Express instance:
```
Server=.\SQLEXPRESS;Database=LapMart;Trusted_Connection=True;
```

---

## Prerequisites

Before running the project, make sure you have the following installed:

- [Visual Studio 2022](https://visualstudio.microsoft.com/) (Community edition is free)
  - Workload: **.NET desktop development**
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (free edition)
- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms) — recommended for DB setup
- .NET Framework 4.8 (included with Windows 10/11; also installable via Visual Studio)

---

## Installation & Setup

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/lapmart.git
cd lapmart
```

### 2. Set Up the Database

1. Open **SQL Server Management Studio (SSMS)** and connect to `.\SQLEXPRESS`.
2. Create a new database named exactly **`LapMart`**:
   ```sql
   CREATE DATABASE LapMart;
   ```
3. Run the schema SQL script located at `docs/database/schema.sql` to create all tables.
4. *(Optional)* Run `docs/database/seed.sql` to populate sample data.

### 3. Configure the Connection String

The connection string is hardcoded in `src/DataAccess.cs`:

```csharp
new SqlConnection(@"Server=.\SQLEXPRESS;Database=LapMart;Trusted_Connection=True;");
```

If your SQL Server instance name differs, update this string accordingly before building.

### 4. Open & Build in Visual Studio

1. Open `src/LaptopManagement.sln` in Visual Studio 2022.
2. Restore NuGet packages if prompted (Build → Restore NuGet Packages).
3. Build the solution: **Build → Build Solution** (`Ctrl+Shift+B`).
4. Run the application: **Debug → Start Without Debugging** (`Ctrl+F5`).

---

## Usage Guide

### Logging In
- Launch the application; the **Login** screen appears.
- Enter your credentials (Username + Password).
- The system detects your role and opens the corresponding dashboard automatically.

### Manager Workflow
1. Navigate via the **Admin Dashboard** sidebar to **Employees**, **Inventory**, **Sales**, or **Reports**.
2. Use the **Inventory** panel to add new laptop models or update stock.
3. Use **Employee Management** to create seller/technician/service executive accounts.
4. Use **Reports** to filter sales by month/year and view trends.

### Seller Workflow
1. From the **Seller Dashboard**, select **New Sale**.
2. Search for the customer or register a new one via **Add Customer**.
3. Search products and **Add to Cart**; quantities and subtotals update automatically.
4. Confirm the sale to record the transaction and update stock.

### Service Executive Workflow
1. Open **New Repair Token** and enter customer and product details.
2. The system checks warranty status automatically.
3. Assign the ticket to an available technician.
4. Monitor status under **Service Queue**.

### Technician Workflow
1. Log in; the **Technician Dashboard** shows only jobs assigned to your account.
2. Select a job and update the repair status.
3. Mark as **Completed** — the completion date is recorded automatically.

---

## Project Structure

```
lapmart/
│
├── src/                              # All Visual Studio project source files
│   ├── LaptopManagement.sln          # Solution file
│   ├── LaptopManagement.csproj       # Project file
│   ├── Program.cs                    # Application entry point
│   ├── DataAccess.cs                 # ADO.NET database helper class
│   ├── App.config                    # Application configuration
│   │
│   ├── admin/                        # Manager/Admin role forms
│   │   ├── admin_Dash.cs             # Admin dashboard
│   │   ├── employee_Admin.cs         # Employee management
│   │   ├── inventory_Admin.cs        # Inventory management
│   │   ├── Sales_Admin.cs            # Sales log view
│   │   ├── Report_Admin.cs           # Sales reports
│   │   └── IndividualSales.cs        # Per-sale detail view
│   │
│   ├── seller/                       # Seller role forms
│   │   ├── Seller.cs                 # Seller dashboard
│   │   ├── SaleProduct.cs            # Cart & checkout
│   │   ├── AddCustomer.cs            # New customer registration
│   │   ├── customerSearchResult.cs   # Customer lookup
│   │   ├── productSearchResult.cs    # Product lookup
│   │   ├── Inventory.cs              # Inventory browse (read-only)
│   │   └── history.cs                # Transaction history
│   │
│   ├── service/                      # Service Executive role forms
│   │   ├── NewToken.cs               # Create repair ticket
│   │   ├── Check.cs                  # Warranty check
│   │   ├── Queue_Status.cs           # Service queue monitor
│   │   └── Warranty_AND_Service.cs   # Warranty & service details
│   │
│   ├── Technician/                   # Technician role forms
│   │   ├── Technician.cs             # Technician dashboard
│   │   └── dashboard_T.cs            # Assigned jobs view
│   │
│   ├── Properties/                   # Assembly info & app resources
│   └── image/                        # UI icons and images
│
├── docs/                             # Project documentation
│   ├── report/
│   │   └── Group_03_Report.docx      # Original project report
│   ├── database/
│   │   ├── schema.sql                # Database creation script
│   │   └── seed.sql                  # Sample data (optional)
│   └── diagrams/
│       ├── ER_Diagram.png            # Entity-Relationship diagram
│       ├── UseCase_Diagram.png       # UML Use Case diagram
│       └── Activity_Diagram.png      # UML Activity diagram
│
├── .gitignore                        # Excludes bin/, obj/, .vs/ etc.
└── README.md                         # This file
