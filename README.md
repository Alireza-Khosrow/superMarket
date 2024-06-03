# superMarket

The store management application (superMarket) is a Windows Forms App developed in C# designed for managing a small store. It features a product management page, a vendor management page, a product category management page for managing inventory categories, and a dedicated page for each vendor. Each vendor can log into their own sales page using a unique username and password to manage their sales.

To store and utilize information in this application, a database is required to create and use tables throughout the program. The reason for using SQL Server in this application is that it is well-suited for C# and it is my personal preference over other databases.

Steps to Create the Project
1. Choosing a Suitable Code Editor:
The text editor selected for designing this application is Visual Studio. This editor is developed by Microsoft and is suitable for languages like C#, C++, and more. Visual Studio makes it much simpler tocreate
WinForms, making it the best choice for this application.
  
To install Visual Studio, visit the Microsoft website and download the version compatible with your Windows operating system. Visual Studio comes in three editions, and for this project, the Community 2022       
edition is used, which is available for free. Other editions require a payment for usage.

2.Installing the Database:
This application uses SQL Server as its database. It is not necessary to install the latest version of SQL Server on your system; older versions can also manage the application's data without issues. While the latest version of SQL Server may offer more features, these additional features are not crucial for your coding needs and newer versions like SQL Server 2012 may consume more system resources. Therefore, this application uses SQL Server 2008 R2.

3.Designing the Application:

Creating the Project:
To create a new project in Visual Studio, open the program and select "New Project" from the menu. This will prompt you to specify a location where the project will be created. After this, you need to select the type of application. Since we want to use a graphical form interface, choose "WinForm App".


Running the Application
The coding for these forms has been completed. Due to Windows' prevention of transferring database files, the tables are provided as queries within the application files. Open SQL Management Studio, input these queries, and execute them to create the main tables for the application. After connecting the application to your local system, run the program to read the tables and ensure it executes without errors.

To open the application, you can either directly launch it from the solution in Visual Studio or run the executable file located at:
superMarket\superMarket\bin\Debug\net8.0-windows\superMarket.exe






















