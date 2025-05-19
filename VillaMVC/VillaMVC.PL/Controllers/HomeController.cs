using Microsoft.AspNetCore.Mvc;
using VillaMVC.BL.Services.Abstract;
using VillaMVC.DAL.Context;
using VillaMVC.DAL.Models;

namespace VillaMVC.PL.Controllers;

public class HomeController : Controller
{

    private readonly IVillaService _service;

    public HomeController(IVillaService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(_service.GetAllVillas());
    }
}
