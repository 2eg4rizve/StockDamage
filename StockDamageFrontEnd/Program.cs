using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StockDamageFrontEnd;
using StockDamageFrontEnd.Services;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient base points to your API
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7035/api/") });

// register services
builder.Services.AddScoped<GodownService>();
builder.Services.AddScoped<SubItemService>();
builder.Services.AddScoped<StockService>();
builder.Services.AddScoped<CurrencyService>();
builder.Services.AddScoped<EmployeeService>();
builder.Services.AddScoped<StockDamageService>();

await builder.Build().RunAsync();
