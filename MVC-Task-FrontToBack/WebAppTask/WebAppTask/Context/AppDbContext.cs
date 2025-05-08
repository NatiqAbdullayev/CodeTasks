using Microsoft.EntityFrameworkCore;
using WebAppTask.Models;

namespace WebAppTask.Context;

public class AppDbContext:DbContext
{
    public DbSet<Product> Products { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=localhost;database=WebAppDatabase;user=root;password=admin;",new MySqlServerVersion(new Version(8,0,36)));
        base.OnConfiguring(optionsBuilder);
    }
}
