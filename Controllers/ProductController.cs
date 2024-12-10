using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Products()
        {
            ProductBL product = new ProductBL();
            List<Product> ProductListModel = product.GetProducts();
            return View("Products",ProductListModel);
        }
        public IActionResult ProductDetails(int id)
        {
            ProductBL productBl = new ProductBL();
            Product ProductModel = productBl.GetProductsById(id);
            return View("ProductDetails",ProductModel);
        }
    }
}
