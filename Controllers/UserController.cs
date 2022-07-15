using FourthTemplateforfoodordering.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FourthTemplateforfoodordering.Controllers
{
    public class UserController : Controller
    {
        private readonly FoodContext fd;
        public UserController(FoodContext fd)
       {
            this.fd = fd;
        }

        public IActionResult Index()
        {
            return View(fd.Products.ToList());
        }

    }
}
