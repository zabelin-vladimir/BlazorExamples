# Blazor examples with DevExpress components
There are two projects:
1) MyTestWebService
2) TestsProject

### MyTestWebService
A sample project implementing a web API with ASP.NET Core. 

ORM is EntityFrameworkCore.

Data base is "Nortwindt", its backup is in [this folder](https://github.com/zabelin-vladimir/BlazorExamples/tree/master/MyTestWebService/MyTestWebService/DBBackup).

Restore the backup on your SQL server and change the connection string in [this file](https://github.com/zabelin-vladimir/BlazorExamples/blob/master/MyTestWebService/MyTestWebService/Models/NWINDContext.cs) correspondingly (see the *OnConfiguring* method). 

### TestsProject
A sample project illustrating several scenarios with using DevExpress components. 

This project uses the connection to the **MyTestWebService** web service. Deploy the **MyTestWebService** project, start it, and specify its address in [this file](https://github.com/zabelin-vladimir/BlazorExamples/blob/master/TestsProject/TestsProject/Data/WebServicePath.cs)
