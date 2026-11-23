-- ============================================================
-- LapMart Database Schema
-- Microsoft SQL Server Express
-- Run this script in SSMS against a new database named: LapMart
-- ============================================================

CREATE DATABASE LapMart;
GO
USE LapMart;
GO

-- Users (Employees)
CREATE TABLE Users (
    UserID      INT IDENTITY(1,1) PRIMARY KEY,
    UserName    NVARCHAR(50)  NOT NULL UNIQUE,
    Password    NVARCHAR(255) NOT NULL,
    FullName    NVARCHAR(100) NOT NULL,
    Role        NVARCHAR(30)  NOT NULL,  -- Manager, Seller, ServiceExecutive, Technician
    Phone       NVARCHAR(20),
    Address     NVARCHAR(255)
);

-- Category
CREATE TABLE Category (
    CategoryID   INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL
);

-- Products
CREATE TABLE Products (
    ProductID        INT IDENTITY(1,1) PRIMARY KEY,
    ProductName      NVARCHAR(150) NOT NULL,
    Brand            NVARCHAR(100),
    Model            NVARCHAR(100),
    Specification    NVARCHAR(MAX),
    UnitPrice        DECIMAL(10,2) NOT NULL,
    QuantityInStock  INT           NOT NULL DEFAULT 0,
    Warranty         INT,                        -- warranty months
    CategoryID       INT FOREIGN KEY REFERENCES Category(CategoryID),
    CreatedAt        DATETIME DEFAULT GETDATE()
);

-- Customers
CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    FullName   NVARCHAR(100) NOT NULL,
    Address    NVARCHAR(255),
    Email      NVARCHAR(100),
    Phone      NVARCHAR(20)
);

-- Sales
CREATE TABLE Sales (
    SaleID      INT IDENTITY(1,1) PRIMARY KEY,
    SaleDate    DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(10,2) NOT NULL,
    CustomerID  INT FOREIGN KEY REFERENCES Customers(CustomerID),
    UserID      INT FOREIGN KEY REFERENCES Users(UserID)
);

-- SaleDetails (line items per sale)
CREATE TABLE SaleDetails (
    SaleDetailsID INT IDENTITY(1,1) PRIMARY KEY,
    SaleID        INT            NOT NULL FOREIGN KEY REFERENCES Sales(SaleID),
    ProductID     INT            NOT NULL FOREIGN KEY REFERENCES Products(ProductID),
    Quantity      INT            NOT NULL,
    UnitPrice     DECIMAL(10,2)  NOT NULL,
    Subtotal      DECIMAL(10,2)  NOT NULL
);

-- Repairs
CREATE TABLE Repairs (
    RepairID           INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID         INT FOREIGN KEY REFERENCES Customers(CustomerID),
    TechnicianID       INT FOREIGN KEY REFERENCES Users(UserID),
    ProductID          INT FOREIGN KEY REFERENCES Products(ProductID),
    ProblemDescription NVARCHAR(MAX),
    Status             NVARCHAR(30) DEFAULT 'Pending',  -- Pending, In Progress, Completed, Not Fixable
    Cost               DECIMAL(10,2),
    CreatedAt          DATETIME DEFAULT GETDATE(),
    CompletedAt        DATETIME NULL,
    AssignedByUserID   INT FOREIGN KEY REFERENCES Users(UserID)
);
GO

-- ============================================================
-- Sample Admin User (Password: admin123 — change before use!)
-- ============================================================
INSERT INTO Users (UserName, Password, FullName, Role, Phone, Address)
VALUES ('admin', 'admin123', 'System Administrator', 'Manager', '01700000000', 'Dhaka');
GO
