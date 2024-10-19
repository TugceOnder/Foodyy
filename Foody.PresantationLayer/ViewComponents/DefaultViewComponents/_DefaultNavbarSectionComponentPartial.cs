using Microsoft.AspNetCore.Mvc;

namespace Foody.PresantationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultNavbarSectionComponentPartial : ViewComponent
  {
        public IViewComponentResult Invoke()
    {
        return View();

    }
    }
}
