using CharityMVC.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMVC.DAL.Context;

public class AppDbContext:DbContext
{
    public DbSet<Cause> Causes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"server=DESKTOP-GTVND9D\SQLEXPRESS;database=CharityDB;Trusted_Connection=true;TrustServerCertificate=true;");
        base.OnConfiguring(optionsBuilder);
    }
}
