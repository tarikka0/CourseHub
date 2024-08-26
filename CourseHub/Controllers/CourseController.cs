using Microsoft.AspNetCore.Mvc;

namespace CourseHub.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {  
            return View(); 
        }

        public IActionResult Apply()
        {
            return View();
        }


    }
}
