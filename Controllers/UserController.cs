using FourthTemplateforfoodordering.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        //public IActionResult MyCart(OrderDetails O)
        //{
        //    return View(O);
        //}
        public IActionResult Buy(int? FoodId)
        {
            var result = fd.Products.Find(FoodId);
            HttpContext.Session.SetString("Price", result.Price.ToString());
            return RedirectToAction("Payment");
        }
        public IActionResult Payment()
        {
            ViewBag.Price = HttpContext.Session.GetString("Price");


            return View();

        }
        [HttpPost]
        public IActionResult Payment(OrderMaster O)
        {
           
            fd.OrderMasters.Add(O);
            fd.SaveChanges();
            return RedirectToAction("Online");
        }
        //public IActionResult Online()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Online(OrderMaster OM)
        //{
        //    fd.OrderMasters.Add(OM);
        //    fd.SaveChanges();
        //    return RedirectToAction("Index"); // Thank has to come
        //}

    }
}
