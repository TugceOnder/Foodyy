using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Foody.PresantationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultHeadSectionComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
