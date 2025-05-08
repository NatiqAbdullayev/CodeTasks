using Microsoft.AspNetCore.Mvc;
using WebAppTask.Models;
using WebAppTask.Services;

namespace WebAppTask.Areas.Admin.Controllers;

[Area("Admin")]
public class DashboardController : Controller
{
    private readonly IProductSerivce _productService;

    public DashboardController(IProductSerivce service)
    {
        _productService = service;
    }
    public IActionResult Index()
    {
        return View(_productService.GetAllProducts());
    }
}
