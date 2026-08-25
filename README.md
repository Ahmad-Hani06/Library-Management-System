# 📚 Library Management System

A complete **Library Management System** built using **C# WinForms, SQL Server, and ADO.NET**, following a **3-Tier Architecture** to separate the Presentation, Business Logic, and Data Access layers.

The system manages the main operations of a library, including books, members, borrowing, returns, fines, sales, payments, and users.

---

## 🚀 Features

### 👤 User Management

* User login
* Active / inactive users
* Remember Me functionality
* Track the user responsible for system operations

### 👥 Member Management

* Add new members
* Update member information
* Search and view member details
* Manage member status

### 📚 Book Management

* Add and update books
* Manage book categories
* Manage multiple physical copies of each book
* Track book copy availability and status

### 🔄 Borrowing System

* Borrow available book copies
* Validate member eligibility
* Automatically assign an available copy
* Store borrowing and due dates
* Track the employee/user who performed the operation

### ↩️ Book Return System

* Return borrowed books
* Automatically update book copy availability
* Detect overdue books
* Generate fines when required

### 💰 Fine Management

* View all fines
* View detailed fine information
* Track paid and unpaid fines
* Pay fines
* Automatically create payment records

### 🛒 Book Sales

* Search for customers and books
* Add multiple books to a sale
* Calculate total sale amount
* Store sale items
* Update sold book copies
* Complete the entire sale using database transactions

### 💳 Payment Management

* View payment records
* Track payments related to fines and sales
* Store payment date, amount, and responsible user

---

## 🏗️ Architecture

The project follows a **3-Tier Architecture**:

```text
Presentation Layer
       ↓
Business Logic Layer
       ↓
Data Access Layer
       ↓
SQL Server Database
```

### Presentation Layer

Built using **Windows Forms** and responsible for:

* Forms
* User Controls
* DataGridViews
* User interaction

### Business Logic Layer

Responsible for:

* Business rules
* Validation
* Application logic
* Communication between the UI and Data Access Layer

### Data Access Layer

Responsible for:

* Database communication
* Executing Stored Procedures
* SQL Server connections
* Retrieving and modifying data using ADO.NET

---

## 🛠️ Technologies Used

* C#
* .NET / Windows Forms
* SQL Server
* T-SQL
* ADO.NET
* Stored Procedures
* Transactions
* DataTables
* User Controls
* Git
* GitHub

---

## 🗄️ Database

The system contains several related entities, including:

```text
Person
Member
User
Book
BookCategory
BookCopy
Borrowing
Fine
FineType
Sale
SaleItem
Payment
```

The database uses:

* Primary and Foreign Keys
* Stored Procedures
* Transactions
* Joins
* Constraints
* Business validation
* Relational database design

---

## 🔐 Data Integrity

Critical operations such as:

* Borrowing books
* Returning books
* Paying fines
* Completing sales

are handled carefully to keep related database operations consistent.

Database **transactions** are used where multiple operations must either succeed together or fail together.

---

## 📁 Project Structure

```text
Library-Management-System
│
├── Presentation Layer
│   ├── Forms
│   ├── Controls
│   └── UI Components
│
├── Business Logic Layer
│   └── Business Classes
│
├── Data Access Layer
│   └── Database Access Classes
│
└── SQL Server Database
    ├── Tables
    └── Stored Procedures
```

---

## 🎯 Project Goals

This project was developed to practice and apply:

* Object-Oriented Programming
* Database Design
* SQL Server
* Stored Procedures
* ADO.NET
* 3-Tier Architecture
* Separation of Concerns
* Business Logic
* Transactions
* Real-world application workflows

---

## 📸 Screenshots

Screenshots of the application will be added here.

```text
Main Dashboard
Members Management
Books Management
Borrowing
Returns
Fine Management
Sales
Payments
```

---

## 🔮 Future Improvements

Possible future improvements include:

* Migrating the system to ASP.NET Core Web API
* Using Entity Framework Core
* Adding JWT Authentication
* Adding Role-Based Authorization
* Building a Web Front-End
* Adding reporting and analytics
* Improving security and logging

---

## 👨‍💻 Author

Developed by **Ahmad Hani**

This project was created as part of my journey in learning **C#, SQL Server, Back-End Development, and Software Architecture**.

---

## ⭐ Support

If you find the project useful or interesting, feel free to give the repository a ⭐.
