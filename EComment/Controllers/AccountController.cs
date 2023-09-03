using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EComment.Models;
using EComment.DAL;

namespace EComment.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationDBContext db = new ApplicationDBContext();
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Account account)
        {
            Account accountLogin = db.Accounts.Where(ac => ac.userName.Equals(account.userName) && account.password.Equals(account.password)).SingleOrDefault();
            if (accountLogin != null)
            {
                return RedirectToAction("Index", "Product");
            }
            else
            {
                ViewBag.ThongBao = "Loi dang nhap";
                return View();
            }

        }
    }
}