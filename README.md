# Lab1MVCApp_Sanchez

**Integrative Programming & Technologies — Laboratory Exercise #1**
ASP.NET Core MVC | .NET 9 | Bootstrap 5

---

## 📋 What This Project Does

A Student Management web application built with ASP.NET Core MVC that demonstrates:
- **Model**: `Student` class with 8 properties
- **Controller**: `StudentController` with Index + Create actions
- **Views**: Student list table (8 columns) + Add Student form

---

## 🖥️ Requirements

| Tool | Version |
|------|---------|
| .NET SDK | 9.0 or later |
| Visual Studio | 2022/2026 (or VS Code) |
| Browser | Chrome, Edge, or Firefox |

Verify your .NET version:
```bash
dotnet --version
```

---

## 🚀 How to Run

### Option A — Visual Studio
1. Open `Lab1MVCApp_Sanchez.csproj` in Visual Studio
2. Press **F5** to build and run
3. Browser opens at `https://localhost:{port}/Student`

### Option B — Command Line (school PC lab)
```bash
# Clone from GitHub
git clone https://github.com/YOUR_USERNAME/Lab1MVCApp_Sanchez.git
cd Lab1MVCApp_Sanchez

# Restore packages and run
dotnet restore
dotnet run
```
Then open your browser to `https://localhost:5001/Student` (or the port shown in the terminal).

---

## 📁 Project Structure

```
Lab1MVCApp_Sanchez/
├── Controllers/
│   ├── HomeController.cs       # Redirects to /Student
│   └── StudentController.cs   # Index + Create actions
├── Models/
│   └── Student.cs             # Student data model (8 properties)
├── Views/
│   ├── Student/
│   │   ├── Index.cshtml       # Student list table
│   │   └── Create.cshtml      # Add Student form
│   ├── Shared/
│   │   └── _Layout.cshtml     # Master layout with navbar
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
├── wwwroot/
│   └── css/
│       └── site.css           # Custom styles
├── appsettings.json
├── Program.cs                 # App entry point & middleware
└── Lab1MVCApp_Sanchez.csproj
```

---

## ✅ Features Implemented

- [x] ASP.NET Core MVC project structure
- [x] `Student` model — 8 properties (Id, Name, Program, Email, Address, Gender, MotherName, FatherName)
- [x] `StudentController` with `Index()` and `Create()` GET/POST
- [x] Student List view with Bootstrap table (8 columns, 8 students)
- [x] Add Student form with Gender dropdown (Male/Female/Other)
- [x] Navigation bar with Students + Add Student links
- [x] Success toast when student is added
- [x] `.gitignore` for ASP.NET Core

---

## 👤 Author

**Sanchez** — Integrative Programming and Technologies
