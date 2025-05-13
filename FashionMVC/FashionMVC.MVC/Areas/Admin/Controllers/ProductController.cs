using FashionMVC.BL.Services;
using FashionMVC.BL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FashionMVC.MVC.Areas.Admin.Controllers;
[Area("Admin")]
public class ProductController : Controller
{
    private readonly IProductService _productService;
    public ProductController(IProductService service)
    {
        _productService = service;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(_productService.GetAllProducts());
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(ProductCreateVM carVM)
    {
        _productService.Create(carVM);
        return RedirectToAction(nameof(Index));
    }
}
