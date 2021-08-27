<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/198061506/20.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T802175)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Index.razor](./CS/DataGridWithWebApiService/DataGridWithWebApiService/Pages/Index.razor)
* [Model.cs](./CS/DataGridWithWebApiService/DataGridWithWebApiService/Data/Model.cs)
* [WebServicePath.cs](./CS/DataGridWithWebApiService/DataGridWithWebApiService/Data/WebServicePath.cs)
* [CategoriesController.cs](./CS/MyTestWebService/MyTestWebService/Controllers/CategoriesController.cs)
* [NWINDContext.cs](./CS/MyTestWebService/MyTestWebService/Models/NWINDContext.cs)
* [Categories.cs](./CS/MyTestWebService/MyTestWebService/Models/Categories.cs)
<!-- default file list end -->

### Blazor Data Grid - How to bind it to the Web API Service

There are two projects:
1) MyTestWebService
2) DataGridWithWebApiService

#### MyTestWebService
A sample project implementing a web API with ASP.NET Core. 

ORM is EntityFrameworkCore.

The data base is "Northwind".

Restore the backup on your SQL server and change the connection string in [this file](./CS/MyTestWebService/MyTestWebService/Models/NWINDContext.cs) correspondingly (see the *OnConfiguring* method). 

#### DataGridWithWebApiService

This project uses the connection to the **MyTestWebService** web service. Deploy the **MyTestWebService** project, start it, and specify its address in [this file](./CS/DataGridWithWebApiService/DataGridWithWebApiService/Data/WebServicePath.cs)
