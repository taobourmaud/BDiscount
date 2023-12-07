using baskets.Models;
using Microsoft.EntityFrameworkCore;

namespace baskets.Helpers;

public class DataContext  : DbContext
{
    private readonly IConfiguration _configuration;
    
    public DbSet<Basket> Baskets { get; set; }
    
    public DataContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(_configuration.GetConnectionString("Default"));
    }
}