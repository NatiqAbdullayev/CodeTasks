using Microsoft.AspNetCore.Mvc;

namespace CarvillaWebApp.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Index","Car");
    }
}
