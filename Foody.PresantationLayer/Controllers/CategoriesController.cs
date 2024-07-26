using Foody.BusinessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresantationLayer.Controllers
{
	public class CategoriesController : Controller
	{
		private readonly ICategoryService _categoryService;

		public CategoriesController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public IActionResult CategoryList()
		{
			var values = _categoryService.TgetAll();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateCategory() 
		{
		return View();
		}

		[HttpPost] IActionResult CreateCategory(Category category)
		{
			_categoryService.TInsert(category);
			return RedirectToAction("CategoryList");
		}
	}
}
