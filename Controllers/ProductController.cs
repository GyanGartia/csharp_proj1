using Microsoft.AspNetCore.Mvc;

namespace BulkyBook.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int id, int catId)
        {
            return View();
        }
    }
}
