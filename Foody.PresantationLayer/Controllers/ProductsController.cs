using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresantationLayer.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult ProductList()
        {
            var values = _productService.TgetAll();
            return View(values);
        }

        public IActionResult ProductListWithCategory() // return içine valu yazmazsak "gory.ExecuteAsync() in" hatası alıyoryuz
        {
            var values= _productService.TProductlistWithCategory();
            return View(values);
        }
    }
}
