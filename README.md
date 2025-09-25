# Hospital Management System

A **Windows Forms-based Hospital Management System** built using C# and .NET.  
This application allows managing doctors, patients, and diagnoses in a hospital environment.

---

## 📂 Project Structure

`
HospitalManagementSystem/
├── Hospital_Management_System.sln
├── Hospital_Management_System/
│ ├── Program.cs
│ ├── sqlConnection.cs
│ ├── Hospital_Management_System.csproj
│
│ ├── Doctor/
│ │ ├── Doctor.cs
│ │ ├── Doctor.Designer.cs
│ │ ├── Doctor.resx
│
│ ├── Patient/
│ │ ├── Patient.cs
│ │ ├── Patient.Designer.cs
│ │ ├── Patient.resx
│
│ ├── Diagnosis/
│ │ ├── Diagnosis.cs
│ │ ├── Diagnosis.Designer.cs
│ │ ├── Diagnosis.resx
│
│ ├── Login/
│ │ ├── Login.cs
│ │ ├── Login.Designer.cs
│ │ ├── Login.resx
│
│ ├── Home/
│ ├── Home.cs
│ ├── Home.Designer.cs
│ ├── Home.resx
`

## 💻 Features

- **User Authentication** – Secure login system.  
- **Doctor Management** – Add, edit, and delete doctor details.  
- **Patient Management** – Add, edit, and delete patient details.  
- **Diagnosis Records** – Record and view patient diagnosis information.  
- **Simple SQL Integration** – Connects to a SQL Server database using `sqlConnection.cs`.  
- **Windows Forms UI** – Intuitive and user-friendly interface.  

---

## 🛠️ Technologies Used

- **C#**
- **.NET Framework**
- **Windows Forms**
- **SQL Server**  

---

## 🚀 Getting Started

### Prerequisites

- Visual Studio 2022 
- .NET Framework 8.0
- SQL Server 

---  
### Setup

1. Clone the repository:
- git clone https://github.com/yourusername/HospitalManagementSystem.git
- Open Hospital_Management_System.sln in Visual Studio
- Restore NuGet packages (if any)
- Build and run the project (F5 or Ctrl+F5)
- Ensure your database connection in sqlConnection.cs matches your SQL Server configuration


📌 Notes

Ensure the database is created and tables are set up as per the application requirements.

The application currently uses local SQL Server authentication, so update credentials as necessary.

📄 License

You can just create a `README.md` in your repo, paste this, and it’s ready for GitHub.  

If you want, I can also **add placeholders for screenshots of your app** so it looks more professional. Do you want me to do that?
