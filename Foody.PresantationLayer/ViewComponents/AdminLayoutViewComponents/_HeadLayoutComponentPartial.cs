using Microsoft.AspNetCore.Mvc;

namespace Foody.PresantationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _HeadLayoutComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
