using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillaMVC.DAL.Models;

namespace VillaMVC.DAL.Context;

public class AppDbContext :DbContext
{
    public AppDbContext(DbContextOptions op):base(op)
    {
        
    }
    public DbSet<Villa> Villas { get; set; }
}
