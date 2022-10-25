# Example-of-using-EF-in-ASP.NET
Although the name of the project is about user registration, the project is not about that.

The project provides a simple example of using Entity Framework in Asp.Net

<img src="screenshots/homePage.png" width="800"/>

<img src="screenshots/addDataPage.png" width="800"/>

<img src="screenshots/Screenshot_1.png" width="800"/>
1. Create new class in model folder

<img src="screenshots/1.png" width="800"/>
2. Adding SqlServer nuget package for project

<img src="screenshots/2.png" width="800"/>
3. To interact with the database through the Entity Framework, we need a data context - a class inherited from the **Microsoft class.EntityFrameworkCore.DbContext**. Therefore, we will add a new class to the Models folder, which we will call ApplicationContext (the name of the context class is arbitrary):

<img src="screenshots/3.png" width="800"/>
4. To connect to the database, we need to set the connection parameters. To do this, change the **appsettings.json** file by adding a connection string definition to it:

<img src="screenshots/4.png" width="800"/>
5. Adding a data context in the form of a service will then allow you to get it in the controller constructor through the dependency injection mechanism.

<img src="screenshots/5.png" width="800"/>
6. To interact with the database, the ApplicationContext db data context variable is defined in the controller.

Using the db method.Users.ToListAsnc() we will get objects from the database, create a list of them and pass them to the view.

And using the db method.Users.Add() an INSERT sql expression is formed for data from the user object, and the db.SaveChangesAsync() method executes this expression, thereby adding data to the database.

<img src="screenshots/6.png" width="800"/>
7. And add a new Create.cshtml view to the Views/Home folder:

<img src="screenshots/7.png" width="800"/>
8. And we will also change (or add in the absence) the Index.cshtml representation, which will be responsible for the output of objects:

![alt text](screenshots/8.png "8")
