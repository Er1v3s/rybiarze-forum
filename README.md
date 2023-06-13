# Rybiarze - Internet Forum

### Application developed using .NET v7.0, MSSQL database, HTML, Bootstrap v5, and CSS technologies

#

### This application represents a fishing forum with basic login and registration functionalities. Users have the ability to add a post consisting of a title, description, content, and an optional image file, which will be displayed on the webpage. Users can also delete their posts at any time. Other users can comment on the posts and delete their own comments.

#

To run the application, you will need to use an MSSQL database. The next step is to create a new database named RybiarzeForumDB and then execute the following commands using the Package Manager Console:

```
PM> Add-Migration "Migration v1.0"
PM> Update-Database
```

At this point, you can start the project.

If you are using a database on a server, you will need to modify the source in the appsettings.json file:

```
"ConnectionStrings": {
    "DatabaseConnection": "Data Source=localhost;Initial Catalog=RybiarzeForumDB;Integrated Security=True"
  }
```
