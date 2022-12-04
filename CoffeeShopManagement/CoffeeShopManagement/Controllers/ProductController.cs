using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopManagement.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
