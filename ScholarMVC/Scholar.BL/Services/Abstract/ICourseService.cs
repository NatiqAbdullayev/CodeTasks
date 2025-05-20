using Scholar.BL.ViewModels;
using Scholar.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.BL.Services.Abstract;

public interface ICourseService
{
    Course GetCourseById(int id);
    List<Course> GetAllCourses();
    void CreateCourse(CourseVM courseVM);
    void UpdateCourse(int id,CourseVM courseVM);
    void DeletCourse(int id);
}
