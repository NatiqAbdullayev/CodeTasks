using Microsoft.AspNetCore.Mvc;
using NFTMarketMVC.BL.Services.Abstract;

namespace NFTMarketMVC.PL.Controllers;

public class HomeController : Controller
{
    private readonly IProductServices _service;
    public HomeController(IProductServices service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(_service.GetAllProducts());
    }
}
