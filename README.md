# Example-of-using-EF-in-ASP.NET
Although the name of the project is about user registration, the project is not about that.

The project provides a simple example of using Entity Framework in Asp.Net

<img src="screenshots/homePage.png" width="100"/>
![alt text](screenshots/homePage.png "1st page")

![alt text](screenshots/addDataPage.png "2nd page")

![alt text](screenshots/Screenshot_1.png "After adding")

1. Create new class in model folder

![alt text](screenshots/1.png "1")

2. Adding SqlServer nuget package for project

![alt text](screenshots/2.png "2")

3. To interact with the database through the Entity Framework, we need a data context - a class inherited from the **Microsoft class.EntityFrameworkCore.DbContext**. Therefore, we will add a new class to the Models folder, which we will call ApplicationContext (the name of the context class is arbitrary):

![alt text](screenshots/3.png "3")

4. To connect to the database, we need to set the connection parameters. To do this, change the **appsettings.json** file by adding a connection string definition to it:

![alt text](screenshots/4.png "4")

5. Adding a data context in the form of a service will then allow you to get it in the controller constructor through the dependency injection mechanism.

![alt text](screenshots/5.png "5")

6. To interact with the database, the ApplicationContext db data context variable is defined in the controller.

Using the db method.Users.ToListAsnc() we will get objects from the database, create a list of them and pass them to the view.

And using the db method.Users.Add() an INSERT sql expression is formed for data from the user object, and the db.SaveChangesAsync() method executes this expression, thereby adding data to the database.

![alt text](screenshots/6.png "6")

7. And add a new Create.cshtml view to the Views/Home folder:

![alt text](screenshots/7.png "7")

8. And we will also change (or add in the absence) the Index.cshtml representation, which will be responsible for the output of objects:

![alt text](screenshots/8.png "8")
