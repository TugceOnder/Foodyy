using Microsoft.AspNetCore.Mvc;

namespace Foody.PresantationLayer.Controllers
{
    public class ErrorPagesCotroller : Controller
    {
        public IActionResult ErrorPage404()
        {
            return View();
        }
    }
}
