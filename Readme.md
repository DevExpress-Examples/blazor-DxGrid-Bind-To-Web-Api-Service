<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/198061506/20.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T802175)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# DataGrid for Blazor - How to bind the Web API Service

You can use the HttpClient to obtain data from the remote service. Save data to a collection and bind the Data Grid to it.

![Data Grid with Data from External Service](images/application-page.png)

The example solution contains two projects:

* **MyTestWebService**: This sample project implements a Web API with ASP.NET Core. Restore the backup on your SQL server and change the connection string in [NWINDContext.cs file](./CS/MyTestWebService/MyTestWebService/Models/NWINDContext.cs#L21) (see the *OnConfiguring* method). 

* **DataGridWithWebApiService**: This project uses the connection to the **MyTestWebService** web service. Deploy the **MyTestWebService** project, start it, and specify its address in the `Path` [variable](./CS/DataGridWithWebApiService/DataGridWithWebApiService/Data/WebServicePath.cs#L3):
    
    ![Localhost Port](images/localhost-port.png)

<!-- default file list -->
## Files to Look At

* [Index.razor](./CS/DataGridWithWebApiService/DataGridWithWebApiService/Pages/Index.razor)
* [Model.cs](./CS/DataGridWithWebApiService/DataGridWithWebApiService/Data/Model.cs)
* [WebServicePath.cs](./CS/DataGridWithWebApiService/DataGridWithWebApiService/Data/WebServicePath.cs)
* [CategoriesController.cs](./CS/MyTestWebService/MyTestWebService/Controllers/CategoriesController.cs)
* [NWINDContext.cs](./CS/MyTestWebService/MyTestWebService/Models/NWINDContext.cs)
* [Categories.cs](./CS/MyTestWebService/MyTestWebService/Models/Categories.cs)
<!-- default file list end -->

## Documentation

* [Data Grid: Data Binding](http://docs.devexpress.devx/Blazor/DevExpress.Blazor.DxDataGrid-1.Data)

* [Data Grid: Bind to Data with EF Core](https://docs.devexpress.com/Blazor/403167/common-concepts/bind-data-grid-to-data-from-entity-framework-core)

## More Examples

[Data Grid - How to use DevExpress Reporting tools to implement export in a WASM application ](https://github.com/DevExpress-Examples/blazor-webassembly-dxdatagrid-export)
