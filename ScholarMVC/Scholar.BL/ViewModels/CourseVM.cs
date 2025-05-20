using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.BL.ViewModels;

public class CourseVM
{
    public string Name { get; set; }
    public string TeacherName { get; set; }
    public string CategoryName { get; set; }
    public double Price { get; set; }
    public IFormFile Image { get; set; }
}
