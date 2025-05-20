using Microsoft.EntityFrameworkCore.ChangeTracking;
using Scholar.BL.Exceptions;
using Scholar.BL.Services.Abstract;
using Scholar.BL.ViewModels;
using Scholar.DAL.Context;
using Scholar.DAL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.BL.Services.Concrete;

public class CourseService : ICourseService
{

    private readonly AppDbContext _context;

    public CourseService(AppDbContext context)
    {
        _context = context;
    }

    private void Save() { _context.SaveChanges(); }



    public void CreateCourse(CourseVM courseVM)
    {
        if (courseVM is null)
        {
            throw new CourseException("Entity cannot be null");
        }
        //Rename File
        string fileName = Path.GetFileNameWithoutExtension(courseVM.Image.FileName);
        string extension = Path.GetExtension(courseVM.Image.FileName);
        string finalName = fileName + Guid.NewGuid().ToString() + extension;

        //Save File
        string path = Path.Combine("C:\\Users\\II Novbe\\source\\repos\\ScholarMVC\\Scholar.PL\\wwwroot\\UploadedImages", finalName);

        using FileStream stream = new FileStream(path, FileMode.Create);
        courseVM.Image.CopyTo(stream);

        Course course = new Course()
        {
            Name = courseVM.Name,
            TeacherName = courseVM.TeacherName,
            CategoryName = courseVM.CategoryName,
            Price = courseVM.Price,
            ImageName = finalName
        };

        _context.Courses.Add(course);
        Save();

    }

    public void DeletCourse(int id)
    {
        var entity = GetCourseById(id);
        _context.Courses.Remove(entity);
        Save();
    }

    public List<Course> GetAllCourses()
    {
        return _context.Courses.ToList();
    }

    public Course GetCourseById(int id)
    {
        var entity = _context.Courses.Find(id);

        if (entity is null)
        {
            throw new CourseException("Entity cannot be null");
        }

        return entity;
    }

    public void UpdateCourse(int id, CourseVM courseVM)
    {
        var entity = GetCourseById(id);

        if (courseVM is null)
        {
            throw new CourseException("Entity cannot be null");
        }

        if (courseVM.Image is not null)
        {
            //Rename File
            string fileName = Path.GetFileNameWithoutExtension(courseVM.Image.FileName);
            string extension = Path.GetExtension(courseVM.Image.FileName);
            string finalName = fileName + Guid.NewGuid().ToString() + extension;

            //Save File
            string path = Path.Combine("C:\\Users\\II Novbe\\source\\repos\\ScholarMVC\\Scholar.PL\\wwwroot\\UploadedImages", finalName);

            using FileStream stream = new FileStream(path, FileMode.Create);
            courseVM.Image.CopyTo(stream);
            entity.ImageName = finalName;
        }

        entity.Name = courseVM.Name;
        entity.TeacherName = courseVM.TeacherName;
        entity.CategoryName = courseVM.CategoryName;
        entity.Price = courseVM.Price;

        Save();
    }

}
