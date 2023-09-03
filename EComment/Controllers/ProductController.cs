using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EComment.DAL;
using EComment.Models;

namespace EComment.Controllers
{

    public class ProductController : Controller
    {
        private ApplicationDBContext data = new ApplicationDBContext();
        // GET: Product
        [HttpGet]
        public ActionResult Index(int? trangSo = 1)
        {
            List<Product> ListProduct = data.Products.ToList();
            int pageSize = 5;
            int danhSach = data.Products.Count();
            ViewBag.trangSo = trangSo;
            ViewBag.tongSoTrang = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(danhSach) / Convert.ToDouble(pageSize)));
            int pageSkips = (int)((trangSo - 1) * pageSize);
            ListProduct = ListProduct.Skip(pageSkips).Take(pageSize).ToList();
            return View(ListProduct);
        }
        public ActionResult Manager()
        {
            ViewBag.Category = data.Categories.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (product != null)
            {
                data.Products.Add(product);
                data.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }


        }
    }
}