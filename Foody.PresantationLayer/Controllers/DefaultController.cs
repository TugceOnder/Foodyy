using Microsoft.AspNetCore.Mvc;

namespace Foody.PresantationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
