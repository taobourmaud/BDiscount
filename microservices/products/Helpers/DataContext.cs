using Microsoft.EntityFrameworkCore;
using products.Models;

namespace products.Helpers;

public class DataContext : DbContext
{
    private readonly IConfiguration _configuration;
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId);

        // modelBuilder.Entity<Product>().Property(p => p.Id).ValueGeneratedOnAdd(); 
        modelBuilder.Entity<Category>().Property(c => c.Id).ValueGeneratedOnAdd(); 
    }
    
    public DataContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(_configuration.GetConnectionString("Default"));
    }
}