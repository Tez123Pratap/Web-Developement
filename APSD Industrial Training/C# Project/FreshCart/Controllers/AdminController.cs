using FreshCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreshCart.Controllers
{
    public class AdminController : Controller
    {
        ECOMMERCEEntities Db = new ECOMMERCEEntities();

        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Categories()
        {
            return View();
        }
        public ActionResult OrederList()
        {
            return View();
        }
        public ActionResult OrderSingle()
        {
            return View();
        }
        public ActionResult Venders()
        {
            return View();
        }
    }
}