using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreshCart.Models
{
    
    public class MainPageData
    {
        ECOMMERCEEntities Db = new ECOMMERCEEntities();
        public List<Mstr_Categories> GetAllTypes()
        {
            List<Mstr_Categories> lstcat = new List<Mstr_Categories>();
            lstcat = Db.Mstr_Categories.Where(x => x.Pid == 0).ToList();
            return lstcat;
        }
        public List<Mstr_Categories>GetAllCategoryById(int id)
        {
            List<Mstr_Categories> lstcat = new List<Mstr_Categories>();
            lstcat = Db.Mstr_Categories.Where(x => x.Pid == id).ToList();
            return lstcat;
        }
    }
}