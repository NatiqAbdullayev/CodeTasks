using Microsoft.EntityFrameworkCore;
using NFTMarketMVC.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFTMarketMVC.DAL.Context;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions op) : base(op)
    {
        
    }
    public DbSet<Product> Products { get; set; }
}
