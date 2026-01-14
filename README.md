# StockWise – Desktop Inventory Management System

## Project Overview
StockWise is a Windows desktop application designed to help small businesses manage products, track inventory levels, and search/filter items quickly. All data is stored locally on the computer using SQLite, providing a simple, reliable, and easy-to-use interface for daily operations.

---

## Goals / Success Criteria
- Users can **add, edit, and delete products**  
- Users can **track stock levels** (increase/decrease)  
- Users can **search by product name** and **filter by category or stock status**  
- Data persists locally between app sessions  
- UI is simple, intuitive, and responsive  

---

## Core Features
- Product CRUD (Create, Read, Update, Delete)  
- Stock management with low-stock highlighting  
- Search and filter functionality  
- Local database using SQLite via Entity Framework Core  
- Desktop UI built with WPF and MVVM architecture  

---

## Out of Scope
- Multiple users or cloud synchronization  
- Advanced reporting or analytics  
- Mobile or web versions  

---

## Tech Stack
- **Language:** C#  
- **Framework:** .NET 9  
- **UI:** WPF  
- **Design Pattern:** MVVM (Model-View-ViewModel)  
- **Database:** SQLite (via Entity Framework Core)  
- **Version Control:** Git + GitHub  

---

## Milestones
1. Project setup (GitHub repo + initial structure)  
2. UI layout completed  
3. MVVM wiring with dummy data  
4. Database setup + CRUD functionality  
5. Stock management, search, filter, and validation  
6. Testing & documentation completed  

---

## Getting Started (for Developers)
1. Clone the repository  
2. Open the solution in Visual Studio 2022 or later  
3. Restore NuGet packages  
4. Build and run the application  
5. The SQLite database will be created automatically on first run  

---

## Future Improvements
- Role-based access (Admin/User)  
- Export inventory data to CSV  
- Undo/redo stock changes  
- Dark/light theme  

---

## License
This project is for portfolio/demo purposes.
