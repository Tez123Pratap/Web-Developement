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
        public ActionResult AddProduct()
        {
            return View();
        }
        public ActionResult AddCategories()
        {
            return View();
        }
        public ActionResult AddSubCategories()
        {
            return View();
        }
        public JsonResult AddProductName(string Name, string Pid)
        {
            bool result = false;
            try
            {
                Mstr_Categories cat = new Mstr_Categories();
                cat.Name = Name;
                if (string.IsNullOrEmpty(Pid))
                    cat.Pid = 0;
                else
                    cat.Pid = int.Parse(Pid);
                cat.Crd = DateTime.Now;
                cat.Crdby = 1;
                cat.IsActive = true;
                cat.IsDelete = false;
                Db.Mstr_Categories.Add(cat);
                Db.SaveChanges();
                result = true;
            }
            catch (Exception e)
            {

            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public JsonResult BindProTypeLst()
        {
            return Json(Db.Mstr_Categories.Where(x => x.Pid == 0).ToList(), JsonRequestBehavior.AllowGet);
        }
        
        public JsonResult BindCategoryLst()
        {
            int[] typeIds = Db.Mstr_Categories.Where(x => x.Pid == 0).Select(x => x.Id).ToArray();

            List<Mstr_Categories> lst = Db.Mstr_Categories.Where(x => typeIds.Contains((int)x.Pid)).ToList();
            return Json(lst, JsonRequestBehavior.AllowGet);
        }
        public JsonResult BindSubCategoryLst()
        {

            int[] typeIds = Db.Mstr_Categories.Where(x => x.Pid == 0).Select(x => x.Id).ToArray();

            int[] catIds = Db.Mstr_Categories.Where(x => typeIds.Contains((int)x.Pid)).Select(x => x.Id).ToArray();
            List<Mstr_Categories> lst = Db.Mstr_Categories.Where(x => catIds.Contains((int)x.Pid)).ToList();
            return Json(lst, JsonRequestBehavior.AllowGet);
        }
        public JsonResult BindCategoryByPid(int Pid)
        {
            MainPageData main = new MainPageData();
            return Json(main.GetAllCategoryById(Pid), JsonRequestBehavior.AllowGet);
        }
    }
}