# Simple Contact List
## Utilizing Asp.Net MVC and Entity Framework

I have created this simple web application called “Simple Contact List” to show the utilization of ASP.NET MVC and Entity Framework. This implements Code-First approach wherein it created the Database on the fly based on the Entity Classes and Configuration.

The .NET Entity Framework has come a long way since its early beginnings where it is currently in version 6.0 and this ORM (Object-Relational Mapping) is stable and mature.

Here are the workflows that you choose from when you want to use Entity Framework:

1. Code-First creating to a new database.
2. Code-First to an existing Database.
3. Model Designer creating to a new Database
4. Existing Database to Generated Model

Usually the fourth item is most frequently used because it is the quickest to get an application up and running. You  can rapidly develop your Database design then generate the Code Model in just a few clicks.

Now here are reasons you should use workflows 1 & 2:

1. **Less cruft, less bloat**. In Code-First your Models become your Database meaning the Models that you build will generate the Database Design/Objects for you.
2. **Greater Control**. In Database-First approach there’s a pile of auto generated codes for your Models to be use in your application and usually the naming conventions are undesirable. There is also a chance that the relationships and associations are not what you want. _**In Code-First**_ you can control every aspect of both your code Models and your Database Design/Objects from the comfort of your business logic/objects. You can also precisely specify relationships, constraints and associations.
3. **Database Version Control**. Creating a version for your Database is not hard (much more effective) with Code-First and Code-First Migrations because your Database Schema is fully based on your code Models.

Please feel free to re-use the web application for any purpose that you need it as long as you give me credits for the codes.

You can grab the files here in Github.

##Cheers!

Posted at my blog
> http://blog.erroldsanchez.com/simple-contact-list-utilizing-asp-net-mvc-and-entity-framework/

See live demo here
> http://demo-simplecontactlist-aspnet-mvc-ef.erroldsanchez.com/