using Microsoft.AspNetCore.Mvc;

namespace KahveProjesi.WebUI.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
