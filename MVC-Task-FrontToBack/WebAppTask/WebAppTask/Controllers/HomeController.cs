using Microsoft.AspNetCore.Mvc;
using WebAppTask.Services;

namespace WebAppTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductSerivce _productSerivce;
        public HomeController(IProductSerivce productSerivce)
        {
            _productSerivce = productSerivce;
        }
        public IActionResult Index()
        {
            return View(_productSerivce.GetAllProducts());
        }
    }
}
