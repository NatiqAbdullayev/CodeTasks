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

    [HttpGet]
    public IActionResult Delete(int id) { return View(); }

    [HttpPost]
    [ActionName("Delete")]
    public IActionResult DeleteProduct(int id) { return View(); }

    [HttpGet]
    public IActionResult Update(int id) { return View(); }

    [HttpPost]
    public IActionResult Update(int id,Object a) { return View(); }
}
