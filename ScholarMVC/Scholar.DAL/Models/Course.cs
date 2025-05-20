using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.DAL.Models;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string TeacherName { get; set; }
    public string CategoryName { get; set; }
    public double Price { get; set; }
    public string ImageName { get; set; }
}
