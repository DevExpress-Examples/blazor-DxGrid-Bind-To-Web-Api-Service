### Blazor Data Grid - How to bind it to the Web API Service

There are two projects:
1) MyTestWebService
2) DataGridWithWebApiService

#### MyTestWebService
A sample project implementing a web API with ASP.NET Core. 

ORM is EntityFrameworkCore.

The data base is "Northwind", and its backup is in  [this folder](https://github.com/DevExpress-Examples/blazor-DxDataGrid-Bind-To-Web-Api-Service/tree/0.0.12%2B/CS/MyTestWebService/MyTestWebService/DBBackup).

Restore the backup on your SQL server and change the connection string in [this file](https://github.com/DevExpress-Examples/blazor-DxDataGrid-Bind-To-Web-Api-Service/blob/0.0.12%2B/CS/MyTestWebService/MyTestWebService/Models/NWINDContext.cs) correspondingly (see the *OnConfiguring* method). 

#### DataGridWithWebApiService

This project uses the connection to the **MyTestWebService** web service. Deploy the **MyTestWebService** project, start it, and specify its address in [this file](https://github.com/DevExpress-Examples/blazor-DxDataGrid-Bind-To-Web-Api-Service/blob/0.0.12%2B/CS/DataGridWithWebApiService/DataGridWithWebApiService/Data/WebServicePath.cs)
