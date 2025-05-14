using CharityMVC.BL.Services;
using CharityMVC.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CharityMVC.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ICauseService _service;
    public HomeController(ICauseService service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        return View(_service.GetAllCauses());
    }
}
