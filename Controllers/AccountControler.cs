using Microsoft.AspNetCore.Mvc;

namespace BulkyBook.Controllers
{
    public class AccountControler : Controller
    {
        public IActionResult Login()
        {
            return View();  
        }
    }
}
