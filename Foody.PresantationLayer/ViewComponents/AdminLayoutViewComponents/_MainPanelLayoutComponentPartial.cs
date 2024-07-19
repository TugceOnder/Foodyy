using Microsoft.AspNetCore.Mvc;

namespace Foody.PresantationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _MainPanelLayoutComponentPartial :ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
