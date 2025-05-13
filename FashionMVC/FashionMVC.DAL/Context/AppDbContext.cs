using FashionMVC.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionMVC.DAL.Context;

public class AppDbContext : DbContext
{

    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=localhost;database=CarvillaDb;user=root;password=admin;", new MySqlServerVersion(new Version(8, 0, 36)));
        base.OnConfiguring(optionsBuilder);
    }

}
