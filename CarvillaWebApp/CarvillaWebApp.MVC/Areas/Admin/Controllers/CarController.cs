using CarvillaWebApp.BL.Services;
using CarvillaWebApp.BL.View_Models;
using CarvillaWebApp.DAL.Models;
using CarvillaWebApp.DAL.View_Models;
using Microsoft.AspNetCore.Mvc;

namespace CarvillaWebApp.MVC.Areas.Admin.Controllers;


[Area("Admin")]
public class CarController : Controller
{
    //DI
    private readonly ICarService _carService;

    public CarController(ICarService carService)
    {
        _carService = carService;
    }

    //Endpoints
    [HttpGet]
    public IActionResult Index()
    {
        return View(_carService.GetAllCars());
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(CarCreateVM carModel)
    {
        _carService.Create(carModel);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        return View(_carService.GetCarById(id));
    }

    [HttpPost]
    [ActionName("Delete")]
    public IActionResult DeleteCar(int id)
    {
        _carService.Delete(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        
        return View(_carService.GetCarById(id));
    }

    [HttpPost]
    [ActionName("Update")]
    public IActionResult Update(int id, Car car)
    {
        _carService.Update(id, car);
        return RedirectToAction(nameof(Index));
    }
}
