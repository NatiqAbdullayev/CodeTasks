using CarvillaWebApp.BL.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarvillaWebApp.MVC.Controllers;

public class HomeController : Controller
{

    private readonly ICarService _carService;

    public HomeController(ICarService carService)
    {
        _carService = carService;
    }

    public IActionResult Index()
    {
        return View(_carService.GetAllCars());
    }
}
