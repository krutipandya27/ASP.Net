using Microsoft.AspNetCore.Mvc;

namespace MOM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult dashboard()
        {
            return View();
        }
    }
}
