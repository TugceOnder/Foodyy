using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresantationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultCategorySectionComponentPartial :ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _DefaultCategorySectionComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke() 
        {
            var value = _categoryService.TgetAll();
            return View(value);
        }
    }
}
