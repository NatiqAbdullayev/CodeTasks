using GymMVC.BL.Services;
using GymMVC.BL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GymMVC.MVC.Controllers;

public class HomeController : Controller
{
    private readonly IProgramModelService _servcie;

    public HomeController(IProgramModelService service)
    {
        _servcie = service;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(_servcie.GetAllPrograms());
    }

   
}
