using FourthTemplateforfoodordering.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FourthTemplateforfoodordering.Controllers
{
    public class AdminController : Controller
    {
        private readonly FoodContext fd;

        public AdminController(FoodContext fd)
        {
            this.fd = fd;
        }
        //public IActionResult Index()
        //{
        //    return View(fd.Products.ToList());
        //}
        //public IActionResult AddProduct()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult AddProduct(Product P)
        //{
        //    // string uniqueFileName = ProcessUploadedFile(P);
        //    fd.Products.Add(P);
        //    fd.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        //public IActionResult ViewReport()
        //{
        //    //var FoodContext = fd.OrderDetail.Include(n => n.OrderID.UserID.Email);
        //   // return View(await applicationDbContext.ToListAsync());
        //    return View(fd.OrderDetail.ToList());
        //}




        //public IActionResult NewOrder()
        //{
        //    return View(fd.OrderDetail.ToList());
        //}
        //public IActionResult Dispatch(int id)
        //{
        //    Product P = fd.Products.Find(id);
        //    fd.Products.Remove(P);
        //    fd.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        public IActionResult Orders()
        {
            return View(fd.OrderMasters.ToList());

        }
    }
}
    

