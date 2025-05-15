using GymMVC.BL.Services;
using GymMVC.BL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GymMVC.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class ProgramController : Controller
{

    private readonly IProgramModelService _services;

    public ProgramController(IProgramModelService service)
    {
        _services = service;
    }

    [HttpGet]
    public IActionResult Index() { return View(_services.GetAllPrograms()); }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(ProgramVM model)
    {
        _services.Create(model);
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public IActionResult Update(int id)
    {
        return View(_services.ReMapp(_services.GetProgramById(id)));
    }

    [HttpPost]
    public IActionResult Update(int id, ProgramVM model)
    {
        _services.Update(id,model);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        _services.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}
