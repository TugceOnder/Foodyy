using Foody.BusinessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Foody.PresantationLayer.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService= categoryService;
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

        public IActionResult DeleteProduct (int id)
        {
            _productService.TDelete(id);
            return RedirectToAction("ProductListWithCategory");
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            var values = _categoryService.TgetAll();
            ViewBag.categories = new SelectList(values,"CategoryId","CategoryName");
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product  product)
        {
            _productService.TInsert(product);
            return RedirectToAction("ProductListWithCategory"); // product kaydettikten sonra anasayfaya gidiyor
        }
        [HttpGet]
        public IActionResult UpdateProduct (int id) 
        {
            var values = _categoryService.TgetAll();
            ViewBag.categories = new SelectList(values, "CategoryId", "CategoryName");
            var productValues = _productService.TGetById(id);
            return View(productValues);
        }

        [HttpPost]
        public IActionResult UpdateProduct (Product product)
        {
            _productService.TUpdate(product);
            return RedirectToAction("ProductListWithCategory");
        }

    }
}
