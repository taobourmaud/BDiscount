using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;
using products;
using products.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProduct, ProductService>();
//IConfiguration _configuration = null;

/*
builder.Services.AddControllersWithViews();
    builder.Services.AddSession();
    builder.Services.AddScoped<IProduct, ProductService>();
    builder.Services.AddDbContext<DataContext>(options =>
        options.UseNpgsql(_configuration.GetConnectionString("Default")));
    builder.Services.AddMemoryCache();*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
