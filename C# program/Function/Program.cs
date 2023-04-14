using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Function fn = new Function();
            Console.WriteLine("Before Function Caliing A=" + fn.A);
            fn.NRWNP();
            Console.WriteLine("After Function Caliing A=" + fn.A);
            fn.NRWPP(10,5);
            Console.WriteLine("result from no return type with passing parameter:="+fn.A);
            int res = fn.RWNPP();
            Console.WriteLine("Result from no return type with no passing parameter:=" + fn.RWNPP());
            Console.WriteLine("Result from no return type with no passing parameter res:=" + res);
            Console.WriteLine("Result from no return type with  passing parameter res:=" + fn.RWPP("APSD","Innovation"));
            Console.ReadKey();
        }
    }
    class Function
    {
       public int A = 0;
        //no return type with no passing parameter
       public void NRWNP()
        {
            A = 20 + 50;
        }
        //no return type with  passing parameter
        public void NRWPP(int a,int b=40)
        {
              A = a + b;
        }
        //no return type with no passing parameter
        public int RWNPP()
        {
            A = 25 + 25;
            return A;
        }
        // return type with  passing parameter
        public string RWPP(string firstName,string LastName)
        {
            return firstName+" " + LastName;
        }
    }
}
