using FashionMVC.BL.Services;
using Microsoft.AspNetCore.Mvc;

namespace FashionMVC.MVC.Controllers;

public class HomeController:Controller
{
    private readonly IProductService _productService;
    public HomeController(IProductService service)
    {
        _productService = service;
    }

    [HttpGet]
    public IActionResult Index() { return View(_productService.GetAllProducts()); }
}
