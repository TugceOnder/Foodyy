using Microsoft.AspNetCore.Mvc;

namespace Foody.PresantationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _FooterLayoutComponentPartial :ViewComponent
	{
		public  IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
