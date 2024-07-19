using Microsoft.AspNetCore.Mvc;

namespace Foody.PresantationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _ScriptsLayoutComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
