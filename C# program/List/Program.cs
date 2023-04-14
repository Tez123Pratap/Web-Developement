using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<datatype> obj=new List<datatype>();
            List<string> color = new List<string>() { "Red","Green","Yellow","Pink","Aqua","Purple","Blue"};
            Console.WriteLine( "OutPut from foreach");
            string cl = color.Where(x => x == "Aqua").FirstOrDefault();
            Console.WriteLine(cl);
            foreach (string clr in color)
            {
                Console.Write(clr + ",");
            }
            Console.WriteLine("");
            color.Add("white");
            Console.WriteLine("output from for loop");
           /* color=color.Where(x=>x=="Red"||x=="White")
            for (int i=0;i<color.Count;i++)
            {
                Console.Write(color[i] + ",");
            }*/
            Console.ReadKey();
        }
    }
}
