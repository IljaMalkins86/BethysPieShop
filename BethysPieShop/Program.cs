using BethysPieShop.Domain;
using BethysPieShop.Infrastracture;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddInfrastractureRepositories();
builder.Services.AddDomainServices();

var app = builder.Build();

app.UseStaticFiles();

app.MapDefaultControllerRoute();

app.Run();
