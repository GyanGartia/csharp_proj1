using Microsoft.AspNetCore.Mvc;

namespace BulkyBook.Components
{
    public class Comments : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        { 
            List<string>  comments = new List<string>() { "Good", "Great", "Keep it up"};
            return View(comments);  
        }
    }
}
