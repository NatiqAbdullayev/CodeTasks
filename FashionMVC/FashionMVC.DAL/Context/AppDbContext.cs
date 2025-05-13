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
        optionsBuilder.UseSqlServer(@"server=DESKTOP-GTVND9D\SQLEXPRESS;Database=FashionMVCDatabase;Trusted_Connection=true;TrustServerCertificate=true;");
        base.OnConfiguring(optionsBuilder);
    }

}
