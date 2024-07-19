using Microsoft.AspNetCore.Mvc;

namespace Foody.PresantationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _SidebarLayoutComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
		
	}
}
