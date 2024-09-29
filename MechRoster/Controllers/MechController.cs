using Microsoft.AspNetCore.Mvc;

namespace MechRoster.Controllers
{
    public class MechController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
