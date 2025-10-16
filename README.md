# 📝 Digital Notes Manager App

A modern and elegant **Windows desktop application** built with **C# (.NET WinForms)** and **Entity Framework Core**, designed to help users efficiently organize their notes, reminders, and categories in a clean and user-friendly interface.

---

## 🚀 Features

✅ User Authentication – Sign up and log in securely.  
✅ Notes Management – Create, edit, and delete notes.  
✅ Reminders System – Set and receive reminders for your tasks.  
✅ Category Management – Add and organize categories easily.  
✅ Dashboard Overview – Visual layout for managing all your data.  
✅ Responsive & Modern UI – Built with Guna UI2 for a professional design.  
✅ Database Integration – Using Entity Framework Core and SQL Server LocalDB for data persistence.

---

## 🧠 Tech Stack

- **Language:** C#  
- **Framework:** .NET (Windows Forms)  
- **ORM:** Entity Framework Core  
- **Database:** SQL Server LocalDB  
- **UI Library:** Guna.UI2.WinForms  
- **IDE:** Visual Studio 2022  

---

## ⚙️ Getting Started

### Prerequisites
Before running the app, make sure you have:

- Visual Studio 2022 or later  
- .NET 6.0 or .NET 8.0 SDK  
- SQL Server Express or LocalDB installed  

### Steps to Run

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Mohammed20367/Digital-Notes-Manager-App.git
   ```
2. **Open the solution** in Visual Studio  
3. **Run database migration:**
   - Open the Package Manager Console  
   - Run:
     ```bash
     update-database
     ```
4. **Press F5** to build and launch the app 🚀  

---

## 🏗️ Build & Publish

To create a standalone executable (.exe):

1. In Visual Studio, go to:  
   **Build → Publish → Folder**
2. Choose:
   - Deployment mode: **Self-contained**  
   - Target runtime: **win-x64**
3. After publishing, find your `.exe` file here:  
   ```
   in\Release
et8.0-windows\publish   ```

---

## 🧱 Technology Overview

| Technology                              | Purpose                 |
| --------------------------------------- | ----------------------- |
| **C# (.NET WinForms)**                  | User Interface          |
| **Entity Framework Core**               | ORM & Database Handling |
| **SQL Server LocalDB**                  | Local Data Storage      |
| **Guna.UI2.WinForms**                   | Modern UI Design        |
| **Microsoft.Toolkit.Uwp.Notifications** | System Notifications    |

---

## 📂 Project Structure

```
Digital Notes Manager App/
├── Category/
│   ├── AddCategory.cs
│   ├── CategoriesPage.cs
├── Dashboard/
│   └── DashboardPage.cs
├── Images/
│   ├── delete.png
│   ├── edite.png
├── Landing Page/
│   ├── LandPage.cs
│   ├── SignUp.cs
├── Main Form/
│   └── Main.cs
├── Migrations/
│   ├── 20251009195759_Nasser.cs
│   ├── DigitalNotesDbContextModelSnapshot.cs
├── Models/
│   ├── AppContextManager.cs
│   ├── Category.cs
│   ├── DigitalNotesDbContext.cs
│   ├── Note.cs
│   ├── Reminder.cs
│   ├── User.cs
├── Notes/
│   ├── AddNoteForm.cs
│   ├── NotesPage.cs
│── Help/
│   └── About.cs
├── Reminder Form/
│   └── RemindersPage.cs
├── Resources/
├── Program.cs
└── Digital_Notes_Manager_App.csproj
```

---

## 🧑‍💻 Author

**Mohamed Nasser**  
📧 [mohamed1.nasser.hassan@gmail.com](mailto:mohamed1.nasser.hassan@gmail.com)  
🌐 [GitHub Profile](https://github.com/Mohammed20367)

---

## 📜 License

This project is licensed under the **MIT License** — feel free to use, modify, and share it with attribution.

---

## 💡 Future Improvements

🧭 Add search and filtering options  
☁️ Sync notes with cloud storage  
📱 Create a cross-platform version using .NET MAUI  

---

✨ *Made with love and C# ❤️*
