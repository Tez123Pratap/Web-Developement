using FreshCart.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreshCart.Controllers
{
    public class LoginController : Controller
    {
        ECOMMERCEEntities Db = new ECOMMERCEEntities();
        Mstr_Login mstrlg = new Mstr_Login();
        
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        
        
        public JsonResult Login(Login lg)
        {
            int n=0;
            var user = Db.Mstr_Login.FirstOrDefault(u => u.Email.Equals(lg.Id) && u.Password.Equals(lg.Password));
            if (user != null)
                n = 1;
            return Json(n, JsonRequestBehavior.AllowGet);
            
        }
    }
}