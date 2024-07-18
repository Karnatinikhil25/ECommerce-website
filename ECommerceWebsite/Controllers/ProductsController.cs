using Microsoft.AspNetCore.Mvc;

namespace ECommerceWebsite.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            ViewData["Message"] = "Product details for product with ID: " + id;
            return View();
        }
    }
}
