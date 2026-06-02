CREATE DATABASE HRMS_DB;
GO

USE HRMS_DB;
GO

-- 1. Departments (no dependencies)
CREATE TABLE Departments (
    DeptID   INT PRIMARY KEY IDENTITY(1,1),
    DeptName NVARCHAR(50) NOT NULL UNIQUE
);

-- 2. Users (no dependencies)
CREATE TABLE Users (
    UserID   INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50)  NOT NULL UNIQUE,
    Password NVARCHAR(50)  NOT NULL,
    Role     NVARCHAR(20)  NOT NULL  -- 'Admin' or 'Employee'
);

-- 3. Employees (depends on Users and Departments)
CREATE TABLE Employees (
    EmpID       NVARCHAR(20)   PRIMARY KEY,
    UserID      INT            NOT NULL,
    DeptID      INT            NOT NULL,
    Name        NVARCHAR(100)  NOT NULL,
    Email       NVARCHAR(100)  NOT NULL UNIQUE,
    Phone       NVARCHAR(15)   NOT NULL,
    Address     NVARCHAR(200)  NOT NULL,
    Salary      DECIMAL(18,2)  NOT NULL,
    Designation NVARCHAR(50)   NOT NULL,
    CONSTRAINT FK_Emp_User FOREIGN KEY (UserID) REFERENCES Users(UserID),
    CONSTRAINT FK_Emp_Dept FOREIGN KEY (DeptID) REFERENCES Departments(DeptID)
);

-- 4. SalarySlips (depends on Employees)
CREATE TABLE SalarySlips (
    SlipID      INT PRIMARY KEY IDENTITY(1,1),
    EmpID       NVARCHAR(20)  NOT NULL,
    GrossSalary DECIMAL(18,2) NOT NULL,
    TaxAmount   DECIMAL(18,2) NOT NULL,
    NetSalary   DECIMAL(18,2) NOT NULL,
    Month       NVARCHAR(20)  NOT NULL,
    CONSTRAINT FK_Slip_Emp FOREIGN KEY (EmpID) REFERENCES Employees(EmpID)
);

-- 5. LeaveRequests (depends on Employees)
CREATE TABLE LeaveRequests (
    LeaveID  INT PRIMARY KEY IDENTITY(1,1),
    EmpID    NVARCHAR(20)  NOT NULL,
    Reason   NVARCHAR(200) NOT NULL,
    FromDate DATE          NOT NULL,
    ToDate   DATE          NOT NULL,
    Status   NVARCHAR(20)  NOT NULL DEFAULT 'Pending',
    CONSTRAINT FK_Leave_Emp FOREIGN KEY (EmpID) REFERENCES Employees(EmpID)
);

-- 6. WorkSchedules (depends on Employees)
CREATE TABLE WorkSchedules (
    ScheduleID INT PRIMARY KEY IDENTITY(1,1),
    EmpID      NVARCHAR(20) NOT NULL,
    ShiftName  NVARCHAR(50) NOT NULL,
    StartTime  NVARCHAR(10) NOT NULL,
    EndTime    NVARCHAR(10) NOT NULL,
    CONSTRAINT FK_Schedule_Emp FOREIGN KEY (EmpID) REFERENCES Employees(EmpID)
);

-- seeding data in Departments
INSERT INTO Departments (DeptName) VALUES ('IT'), ('HR'), ('Sales'), ('Finance');

-- to verify everything was created
SELECT TABLE_NAME 
FROM INFORMATION_SCHEMA.TABLES 
WHERE TABLE_TYPE = 'BASE TABLE'
ORDER BY TABLE_NAME;