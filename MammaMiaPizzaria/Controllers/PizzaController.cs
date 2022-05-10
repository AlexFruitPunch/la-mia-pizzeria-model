using Microsoft.AspNetCore.Mvc;

namespace MammaMiaPizzaria.Controllers
{
    public class PizzaController : Controller
    {
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
