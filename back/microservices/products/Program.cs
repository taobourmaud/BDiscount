using Microsoft.EntityFrameworkCore;
using products.Repository;
using products.Repository.Interfaces;
using products.Services;
using products.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("appsettings.json")
    .Build();

builder.Services.AddDbContext<DataContext>(options =>
{
    Console.WriteLine(configuration.GetConnectionString("Default"));
    options.UseNpgsql(configuration.GetConnectionString("Default"));
});


builder.Services.AddScoped<IProductService, ProductService>();

///////////////// REPOSITORY ///////////////

builder.Services.AddScoped<IProductRepository, ProductRepository>();

/////////////// COMPILATION ///////////////

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
