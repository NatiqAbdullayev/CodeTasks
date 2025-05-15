using GymMVC.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMVC.DAL.Context;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions options):base(options)
    {
    }
    public DbSet<ProgramModel> Programs { get; set; }

}
