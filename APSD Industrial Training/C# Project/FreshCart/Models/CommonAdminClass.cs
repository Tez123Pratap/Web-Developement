using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreshCart.Models
{
    public class CommonAdminClass
    {
        Random random = new Random();
        public string GenarateSKU()
        {
            
            string s1 = random.Next(100000000, 999999999).ToString();
            string s2 = random.Next(100000000, 999999999).ToString();
            return s1 + s2;
        }
        public string GenerateProCode(string name)
        {
            string s1 = name.Substring(0, 4);
            string s2 = random.Next(100000000, 999999999).ToString();
            return s1 + s2;
        }
    }
}