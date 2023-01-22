using Microsoft.AspNetCore.Mvc;

namespace APITest.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
