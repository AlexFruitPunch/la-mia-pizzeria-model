using Microsoft.AspNetCore.Mvc;

namespace MammaMiaPizzaria.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("MiaVista");
        }

        public IActionResult NuovoPath()
        {
            return View();
        }
    }
}
