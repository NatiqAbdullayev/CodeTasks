using Microsoft.AspNetCore.Mvc;
using VillaMVC.BL.Services.Abstract;
using VillaMVC.BL.ViewModels;

namespace VillaMVC.PL.Areas.Admin.Controllers;

[Area("Admin")]
public class VillaController : Controller
{

    private readonly IVillaService _service;

    public VillaController(IVillaService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(_service.GetAllVillas());
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(VillaVM model)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        _service.Create(model);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        return View(_service.ReMap(_service.GetVillaById(id)));
    }

    [HttpPost]
    public IActionResult Update(int id,VillaVM model)
    {
        _service.Update(id,model);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        _service.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}
