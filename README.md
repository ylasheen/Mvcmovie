# 🎬 MvcMovie — ASP.NET Core MVC Movie App

An end‑to‑end **ASP.NET Core MVC** application that manages movie data with **Entity Framework Core** and **SQL Server LocalDB**.  
The project follows the official MVC tutorial flow (Model → View → Controller), including **migrations**, **validation**, and a clean **Bootstrap 5** UI with a **Dark Mode** switch.

## ✨ Highlights
- MVC architecture with strongly‑typed Views and Controllers.
- EF Core (Code‑First): `InitialCreate` + `AddRating` migrations; `DbContext` configured for SQL Server LocalDB.
- Full CRUD for `Movie` (Create/Read/Update/Delete).
- **Validation**: Data Annotations (server) + jQuery Unobtrusive (client).
- **UI/UX**: Bootstrap 5 layout, responsive navbar/footer, Dark/Light toggle (saved via `localStorage`).

## 🗂 Tech Stack
- **Backend**: ASP.NET Core MVC (.NET)
- **Data**: Entity Framework Core, SQL Server LocalDB
- **Frontend**: Razor Views, Bootstrap 5, jQuery validation
- **Tooling**: Visual Studio 2022, Git/GitHub

## 🚀 Getting Started (Local)
```bash
git clone https://github.com/ylasheen/Mvcmovie.git
cd Mvcmovie
dotnet restore
dotnet ef database update
dotnet run
# Navigate to https://localhost:<port>/Movies
