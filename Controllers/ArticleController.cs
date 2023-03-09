using Microsoft.AspNetCore.Mvc;

namespace BulkyBook.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
