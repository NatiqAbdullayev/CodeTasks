using Microsoft.AspNetCore.Mvc;
using Scholar.BL.Services.Abstract;

namespace Scholar.PL.Controllers;

public class HomeController : Controller
{
    private readonly ICourseService _service;

    public HomeController(ICourseService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(_service.GetAllCourses());
    }
}
