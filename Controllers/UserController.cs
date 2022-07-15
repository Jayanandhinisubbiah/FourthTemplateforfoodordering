using Microsoft.AspNetCore.Mvc;

namespace FourthTemplateforfoodordering.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
