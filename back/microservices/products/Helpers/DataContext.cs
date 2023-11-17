using back.microservices.products.Entities;
using Microsoft.EntityFrameworkCore;
using products.Models;

public class DataContext : DbContext
{
    private readonly IConfiguration _configuration;
    public DbSet<Product> Products { get; set; }

    public DataContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(_configuration.GetConnectionString("Default"));
    }
}