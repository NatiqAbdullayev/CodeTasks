using Microsoft.AspNetCore.Mvc;
using Scholar.BL.Services.Abstract;
using Scholar.BL.ViewModels;

namespace Scholar.PL.Areas.Admin.Controllers;

[Area("Admin")]
public class CourseController : Controller
{
    private readonly ICourseService _service;

    public CourseController(ICourseService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(_service.GetAllCourses());
    }

    [HttpGet]
    public IActionResult Create()
    { 
        return View();
    }

    [HttpPost]
    public IActionResult Create(CourseVM model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        _service.CreateCourse(model);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        var entity = _service.GetCourseById(id);
        CourseVM model = new()
        {
            Name = entity.Name,
            TeacherName = entity.TeacherName,
            Price = entity.Price,
            CategoryName = entity.CategoryName
        };
        return View(model);
    }
    [HttpPost]
    public IActionResult Update(int id,CourseVM model)
    {
        _service.UpdateCourse(id,model);
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public IActionResult Delete(int id)
    {
        _service.DeletCourse(id);
        return RedirectToAction(nameof(Index));
    }
}
