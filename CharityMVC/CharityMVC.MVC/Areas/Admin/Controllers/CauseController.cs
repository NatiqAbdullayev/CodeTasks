using CharityMVC.BL.Services;
using CharityMVC.BL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CharityMVC.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class CauseController : Controller
{
    private readonly ICauseService _service;
    public CauseController(ICauseService service)
    {
        _service = service;
    }


    [HttpGet]
    public IActionResult Index()
    {
        return View(_service.GetAllCauses());
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Update(int id)
    {

        return View(_service.ReMapping(_service.GetCauseById(id)));
    }

    [HttpPost]
    public IActionResult Update(int id, CauseVM causeModel)
    {
        _service.Update(id, causeModel);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        _service.Delete(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public IActionResult Create(CauseVM cause)
    {
        Console.WriteLine(cause.File.FileName);
        if (!ModelState.IsValid)
        {
            throw new Exception("Model cannot be null");
        }
        _service.Add(cause);
        return RedirectToAction(nameof(Index));
    }
}
