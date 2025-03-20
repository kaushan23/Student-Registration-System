Student and Subject Registration System

Overview

The Student and Subject Registration System is a web-based application developed using C#, ASP.NET Core, and SQL Server. It enables educational institutes to efficiently manage student registrations and subject enrollments. The system follows the MVC (Model-View-Controller) architecture and integrates Entity Framework Core for seamless database operations.

Features

Student Registration: Allows administrators to register new students with details such as First Name, Last Name, Email, and Date of Birth.

Subject Registration: Enables admins to add new subjects, including Subject Name and Description.

Database Integration: Utilizes SQL Server for storing student and subject data.

Validation & Security: Ensures data integrity through built-in validation mechanisms.

User-Friendly Interface: Designed with a responsive and intuitive UI using Razor Views, Bootstrap, and CSS.

Technologies Used

Backend: C#, ASP.NET Core

Frontend: Razor Views (HTML, CSS, Bootstrap)

Database: SQL Server

ORM: Entity Framework Core

Tools: Visual Studio, SQL Server Management Studio (SSMS)

Installation & Setup

Follow these steps to set up and run the project locally:

Clone the Repository:

Open in Visual Studio:

Open the .sln file in Visual Studio.

Update the Database Connection:

Open appsettings.json.

Update the connection string to match your SQL Server instance.

Run Database Migrations:

Run the Application:

Access the Application:

Open your browser and navigate to http://localhost:5000 (or the specified port).

Contribution

Feel free to contribute to this project by submitting issues or creating pull requests. Any suggestions or improvements are welcome!

License

This project is licensed under the MIT License.
