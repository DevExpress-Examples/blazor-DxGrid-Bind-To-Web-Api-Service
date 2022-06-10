using DataGridWithWebApiService.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDevExpressBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

// Server Side Blazor doesn't register HttpClient by default
if (!builder.Services.Any(x => x.ServiceType == typeof(HttpClient))) {
    // Setup HttpClient for server side in a client side compatible fashion
    builder.Services.AddScoped<HttpClient>(s => {
        // Creating the URI helper needs to wait until the JS Runtime is initialized, so defer it.
        var uriHelper = s.GetRequiredService<NavigationManager>();
        return new HttpClient {
            BaseAddress = new Uri(uriHelper.BaseUri)
        };
    });
}
builder.Services.AddScoped<WebServicePath>();

builder.Services.Configure<DevExpress.Blazor.Configuration.GlobalOptions>(options => {
    options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
});
builder.WebHost.UseWebRoot("wwwroot");
builder.WebHost.UseStaticWebAssets();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();


app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();