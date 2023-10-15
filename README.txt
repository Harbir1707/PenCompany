Assignment 1 -  #PenCompany ASP.NET Core Web Application
Starting time: 1511
Date: 2023-10-12
Author: Harbir kaur powar 0825064

Project name: PenCompany
using ASP.NET version 3.1 
Authentication: none

Add Conroller:-
Created a default ASP.NET Core web Application
Named the project to PenCompany and http enabled by default
firslty i commented out the  //"sslPort": 44344
Then add the controller in controller folder and add new item - "PenCompanyController.cs"
do some changes in public method and then tested it by using https://localhost:portnumber/PenCompany
The routing format is set in the Configure method in Startup.cs file using this pattern - pattern: "{controller=Home}/{action=Index}/{id?}");
now tested it by using https://localhost:{PORT}/PenCompany/Welcome and it is showing the output
In PenCompanyController.cs change the welcome method with new method and run it 
then replace the above welcome method with new method and run it by using https://localhost:{PORT}/PenCompany/Welcome/3?name=
got the output!
Now open the Startup.cs file and replace the welcome method

Add View:-
Go to the PenCompanyController.cs and replace the index method
In view folder, add a new folder and name the folder PenCompany
Right-click on the Views/PenCompany folder, and then add new item with name Index.cshtml
Then replace the contents of the Views/PenCompany/Index.cshtml and navigate to  https://localhost:{PORT}/PenCompany
Its showing the output
Now open the Views/Shared/_Layout.cshtml file and replace the content of the layout.cshtml file and run it (got the ouput)
Verified the Views/_ViewStart.cshtml file
Open the Index.html and change the title and h2 element 
now save it and run it by using https://localhost:{PORT}/PenCompany (everything runs properly)
In PenCompanyController.cs , change the welcome method to add a Message and NumTimes value to the ViewData dictionary
Create a welcome.cshtml to the PenCompany folder and now create the loop in the welcome.cshtml which display the NumTimes while opening the page
Save it and browse it - https://localhost:{PORT}/PenCompany/Welcome?name=Rick&numtimes=4
Run successfully!

Add Model:-
Add a new class to the Model folder with name Pen

Database:-
Then installed the Microsoft.EntityFrameworkCore.SqlServer version 3.1.0
Create a Data folder and add PenCompanyContext.cs file and code adjustment were made
Add the code in the Startup.cs file
Connection string was added to the appsettings.json file
Add new Scaffolded item to the Controller folder and completed the add Controller dialog
Run the command in the PMC and Add-Migration InitialCreate
Update-Database
verified the Views/PenCompany/Details.cshtml file and working fine

SeedData:-
Create a new class and SeedData in the Models folder and replace the code wit new one 
did some changes in Program.cs
Then run it and i got the error 
I'm trying to fix it but still i'm stuck there...
