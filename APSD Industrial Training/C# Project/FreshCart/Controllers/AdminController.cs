using FreshCart.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
        #region for Category
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
        #endregion
        #region for product
        public ActionResult AddRealProduct()
        {
            return View();
        }
       
        public JsonResult SaveProduct(Product product)
        {
            bool result = false;
            if(product.ProId!=0)
            {

            }
            else
            {
                product.Crd = DateTime.Now;
                product.CrdBy = 1;
                product.isActive = true;
                product.isDelete = false;
                Db.Products.Add(product);
                Db.SaveChanges();
                result = true;
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GenCode(string Name)
        {
            CommonAdminClass com = new CommonAdminClass();
            string res=com.GenerateProCode(Name);
            return Json(res, JsonRequestBehavior.AllowGet);

        }
        #endregion
        [HttpPost]
        public ActionResult UploadFiles()
        {
            if (Request.Files.Count > 0)
            {
                string finalimgnams = "";
                try
                {
                    HttpFileCollectionBase files = Request.Files;
                    for (int i = 0; i < files.Count; i++)
                    {
                        HttpPostedFileBase file = files[i];
                        finalimgnams += file.FileName + ",";
                        string fname;
                        fname = Path.Combine(Server.MapPath("~/Uploads/"), file.FileName);
                        file.SaveAs(fname);
                    }
                    finalimgnams = finalimgnams.Trim(',');
                    return Json(finalimgnams, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json("Error occurred. Error details: " + ex.Message);
                }
            }
            else
            {
                return Json("No files selected.");
            }
        }
    }
}