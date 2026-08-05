# Human Resource Management System (HRMS)

A desktop HR management application built in C# (WinForms) with a layered
architecture and a SQL Server backend. Built as a course project to replace
scattered spreadsheets and manual payroll with a single role-based system.

## Overview

HRMS manages employees, departments, payroll, leave requests, and work
schedules from one application. It supports two roles — **Admin** and
**Employee** — and automatically opens the correct dashboard based on who
logs in.

**Problem it addresses:**

* Employee records scattered across files/spreadsheets, hard to find or update
* Manual, error-prone salary/tax calculations
* No formal way to track leave request status
* No access control over sensitive HR data
* Informal, undocumented shift scheduling

## Features

**Admin**

* Add, search, update, delete, and promote/demote employees
* Add/delete departments (blocks deletion if employees are still assigned)
* Generate salary slips with automatic 7% tax deduction and net salary calculation
* Approve or reject employee leave requests
* Assign work shifts (Morning / Evening / Night) to employees
* First-time setup flow to create the initial master admin account

**Employee**

* View own profile (department, designation, salary, assigned shift)
* View generated salary slips
* Submit and track leave requests (Pending / Approved / Rejected)
* Change password (with format validation)

**Shared**

* Role-based login — one login screen routes to the correct dashboard
* Centralized input validation (name, username, password, phone, salary rules)
with inline error messages, no popups

## Architecture

The solution is split into two projects to separate UI from business/data logic:

```
HRMS/
├── HRMS.Library/          # Business \& data logic — no UI code
│   ├── BL/                # Business Logic layer (validation, rules, calculations)
│   │   ├── PersonBL.cs        # abstract base — shared person fields (name, email, phone...)
│   │   ├── UserBL.cs          # extends PersonBL — adds login (username/password/role)
│   │   ├── EmployeeBL.cs      # extends UserBL — adds salary, designation, department
│   │   ├── AdminBL.cs         # extends UserBL — adds adminID
│   │   ├── DepartmentBL.cs
│   │   ├── LeaveBL.cs
│   │   └── SalarySlipBL.cs
│   ├── DL/                # Data Layer — talks directly to SQL Server
│   │   ├── UserDL.cs, EmployeeDL.cs, DepartmentDL.cs
│   │   └── LeaveDL.cs, SalaryDL.cs, ScheduleDL.cs
│   ├── Interfaces/
│   │   ├── ISaveable.cs        # Save(), Delete(string id)
│   │   ├── ISearchable.cs      # GetAll(), GetByID(string id)
│   │   └── IValidatable.cs     # Validate(), GetValidationError()
│   └── Utility/
│       └── Validations.cs      # static class — all input validation rules in one place
│
└── HRMS.UI/                # Windows Forms front end
    ├── Forms/
    │   ├── LoginForm.cs, InitSetupForm.cs
    │   ├── AdminDashboard.cs, EmployeeDashboard.cs
    │   └── SubForms/           # AddEmployee, UpdateEmployee, PromoteDemote, SalarySlip
    └── Program.cs               # entry point
```

**Why this structure:** `HRMS.UI` never talks to the database directly — it
calls into `HRMS.Library`'s BL classes, which call the DL classes. This keeps
the forms focused purely on display/interaction, and means the business rules
and data access could be reused by a different front end without rewriting them.

## OOP Concepts Demonstrated

This project was also a deliberate exercise in applying OOP principles:

* **Abstraction** — `PersonBL` is an abstract base class; the three interfaces
(`ISaveable`, `ISearchable`, `IValidatable`) define contracts without
exposing implementation
* **Inheritance** — `PersonBL → UserBL → EmployeeBL` / `AdminBL`, each layer
adding more specific fields without repeating the base ones
* **Encapsulation** — fields are `protected`/`private` throughout, exposed
only through controlled getters/setters
* **Polymorphism (dynamic)** — `Validate()`/`GetValidationError()` are
overridden differently by each subclass
* **Polymorphism (static)** — `EmployeeBL.CalculateTax()` is overloaded
(default 7% rate, or a custom rate passed in)
* **Static members** — `Validations` is a fully static utility class, called
as `Validations.PasswordCheck()` with no object instantiation
* **Interfaces** — used to define contracts (`ISaveable`, `ISearchable`,
`IValidatable`) implemented across the BL/DL layers

## Tech Stack

* C# (.NET Framework, WinForms)
* SQL Server
* Layered architecture: UI → Business Logic (BL) → Data Layer (DL)

## Getting Started

1. Clone the repo
2. Open `HRMS.slnx` in Visual Studio
3. Update the connection string in `HRMS.UI/App.config` to point to your local SQL Server instance
4. Run `setup\_database.sql` (in the repo root) in SQL Server Management Studio, or via `sqlcmd` — this creates the `HRMS\_DB` database and all six tables (`Departments`, `Users`, `Employees`, `SalarySlips`, `LeaveRequests`, `WorkSchedules`), with foreign key constraints between them, and seeds four starter departments (IT, HR, Sales, Finance)
5. Build and run — since no admin account exists yet, the app will open the **Initial Setup** screen first to create the master admin

## Screenshots

### Admin Dashboard

!\[Admin Dashboard](screenshots/Admin-dashboard.png)

### Leave Management

!\[Leave Management](screenshots/Leaves.png)

### Payroll / Salary Slip

!\[Payroll](screenshots/Payroll.png)

### Work Schedules

!\[Work Schedules](screenshots/Schedule.png)

## Author

Uswa Nawaz — CS student, University of Engineering and Technology, Lahore

