using Microsoft.EntityFrameworkCore;
using Scholar.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.DAL.Context;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions op) : base(op)
    {
    }
    public DbSet<Course> Courses { get; set; }

}
