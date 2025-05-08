using Microsoft.AspNetCore.Mvc;
using WebAppTask.Models;
using WebAppTask.Services;

namespace WebAppTask.Areas.Admin.Controllers;

[Area("Admin")]
public class ProductController : Controller
{
    private readonly IProductSerivce _productService;

    public ProductController(IProductSerivce service)
    {
        _productService = service;
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        return View(_productService.GetProductById(id));
    }

    [HttpPost]
    [ActionName("Create")]
    public IActionResult CreateProduct(Product p)
    {
        _productService.Add(p);
        return RedirectToAction("Index", "Dashboard");
    }

    [HttpPost]
    [ActionName("Delete")]
    public IActionResult Delete(int id)
    {
        _productService.Delete(id);
        return RedirectToAction("Index","Dashboard");
    }

    [HttpPost]
    [ActionName("Update")]
    public IActionResult Update(int id, Product p)
    {
        _productService.Update(id, p);
        return RedirectToAction("Index", "Dashboard");
    }
}
