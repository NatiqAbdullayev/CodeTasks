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
    public IActionResult Delete(int id) { 

        _productService.Delete(id);
        return RedirectToAction(nameof(Index)); 
    }

    //[HttpPost]
    //[ActionName("Delete")]
    //public IActionResult DeleteProduct(int id) { return View(); }

    [HttpGet]
    public IActionResult Update(int id) { 

        return View(_productService.ReMapping(id)); 
    }

    [HttpPost]
    public IActionResult Update(int id,ProductCreateVM productModel) {
        _productService.Update(id,productModel);
        
        return RedirectToAction(nameof(Index)); 
    
    
    }
}
