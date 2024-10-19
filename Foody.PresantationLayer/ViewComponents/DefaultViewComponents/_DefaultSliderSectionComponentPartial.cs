using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresantationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultSliderSectionComponentPartial : ViewComponent
    {
        private readonly ISliderService _sliderService;

        public _DefaultSliderSectionComponentPartial (ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = _sliderService.TgetAll();
            return View("Deafult",values);

        }
    }
}