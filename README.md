# WindowsFormsApp

# BankDatabase WinForms App

A C# Windows Forms application that manages a simple bank database using MySQL.  
The system allows you to manage customers, their accounts, and related details through a graphical user interface and stored procedures in the database.

---

## Features

- **Customer Management**
  - List all customers in a DataGridView.
  - Add new customers.
  - Edit existing customers.
  - Delete customers.
  - View detailed information for a selected customer.

- **Account Management**
  - Open new accounts for customers.
  - Set account type (e.g., Vadesiz / Vadeli).
  - Set initial balance, opening date and status (Aktif / Pasif).
  - Navigate to a dedicated “Accounts” form for management.

- **MySQL Integration**
  - Database `BankDatabase_spot`.
  - Tables such as customers (`BankDatabase_Müşteri`), accounts, and branches.
  - Uses **stored procedures** for insert/update/delete operations.
  - Can use **triggers** to automatically update account status or balance logic.

- **WinForms UI**
  - Main form shows the customer list.
  - Separate forms for:
    - Adding a customer (`FormAddMusteri`)
    - Editing a customer (`FormEditMusteri`)
    - Deleting a customer (`FormDeleteMusteri`)
    - Managing accounts (`FormHesap`)
    - Viewing customer details (`FormMusteriDetay`)

---

## Technologies Used

- **Language:** C#  
- **Framework:** .NET Framework 4.8 (Windows Forms)  
- **Database:** MySQL (MySQL Server + MySQL Workbench)  
- **Data Access:** `MySql.Data` (MySQL Connector/NET)  
- **IDE:** Visual Studio 2022  

---

## Project Structure

```text
BankDatabase-WinFormsApp/
│
├─ WindowsFormsApp2.sln          # Visual Studio solution
├─ .gitignore
├─ README.md
│
├─ WindowsFormsApp2/             # WinForms project
│   ├─ Form1.cs                  # Main form (customer list)
│   ├─ FormAddMusteri.cs        # Add customer form
│   ├─ FormEditMusteri.cs       # Edit customer form
│   ├─ FormDeleteMusteri.cs     # Delete customer form
│   ├─ FormHesap.cs             # Accounts form
│   ├─ FormMusteriDetay.cs      # Customer detail form
│   ├─ App.config               # Connection string configuration
│   └─ ... other WinForms files
│
└─ sql/                          # Database scripts
    └─ BankDatabase_spot_schema.sql

---
## Database Setup

1. **Install MySQL**
   - Install MySQL Server and MySQL Workbench (or any MySQL client).
   - Make sure you know your MySQL username and password (e.g. `root`).

2. **Create the database and objects**
   - Open `sql/BankDatabase_spot_schema.sql` in MySQL Workbench.
   - Select the whole script and execute it.
   - This will:
     - Create the database `BankDatabase_spot`.
     - Create required tables (branches, customers, accounts, etc.).
     - Create stored procedures (for insert/update/delete).
     - Optionally create triggers (if included in the script).

3. **Check that the schema exists**
   - In Workbench, you should now see a schema named `BankDatabase_spot`.
   - Expand it and verify that the tables and procedures are created.



