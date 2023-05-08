using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ControllerDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public string Index(string id)
        //{
        //    //return "Tez Pratap First MVC project";
        //    return "Id = "+id+"Name = "+Request.QueryString["name"];
        //}
        //public string GetDetails()
        //{
        //    return "GetDetails is invoked";
        //}
        public ActionResult Index()
        {
            ViewBag.Countries=new List<string>()
            {
                "India",
                "US",
                "UK",
                "Canda"
            };
            return View();
        }
    }
}