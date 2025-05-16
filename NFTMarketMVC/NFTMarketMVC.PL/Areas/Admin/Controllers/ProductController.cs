using Microsoft.AspNetCore.Mvc;
using NFTMarketMVC.BL.Services.Abstract;
using NFTMarketMVC.BL.ViewModels;

namespace NFTMarketMVC.PL.Areas.Admin.Controllers;

[Area("Admin")]
public class ProductController : Controller
{
    private readonly IProductServices _services;
    public ProductController(IProductServices service)
    {
        _services = service;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(_services.GetAllProducts());
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(ProductVM model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        _services.Create(model);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        return View(_services.GetProductVM(_services.GetProductById(id)));
    }

    [HttpPost]
    public IActionResult Update(int id,ProductVM model)
    {
        _services.Update(id,model);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int id) {

        _services.Delete(id);
        return RedirectToAction(nameof(Index));
    }

}
