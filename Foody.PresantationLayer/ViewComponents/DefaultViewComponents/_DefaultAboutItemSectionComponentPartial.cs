using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresantationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultAboutItemSectionComponentPartial:ViewComponent
    {
        private readonly IAboutItemService _aboutItemService;

        public _DefaultAboutItemSectionComponentPartial(IAboutItemService aboutItemService)
        {
            _aboutItemService = aboutItemService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutItemService.TgetAll();
            return View(values);
        }
    }
}
