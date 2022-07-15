using FourthTemplateforfoodordering.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace FourthTemplateforfoodordering.Controllers
{
    public class LoginController : Controller
    {
        private readonly FoodContext fd;
        private readonly ISession session;
        public LoginController(FoodContext fd, IHttpContextAccessor httpContextAccessor)
        {
            this.fd = fd;
            session = httpContextAccessor.HttpContext.Session;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(User U)
        {
            fd.Users.Add(U);
            fd.SaveChanges();
            return RedirectToAction("Index", "Home");// Have to give the redirection page
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User U)
        {
            var result = (from i in fd.Users
                          where i.FName == U.FName && i.Password == U.Password
                          select i).SingleOrDefault();
            if (result != null)
            {
                HttpContext.Session.SetString("UserName", result.FName);
                return RedirectToAction("Index", "Home");// Category in front UI
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Login");
        }
        public IActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminLogin(User U)
        {

            return RedirectToAction("Index", "Home");// Admin Panel should come 

        }
    }
}
