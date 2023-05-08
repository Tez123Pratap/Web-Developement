using System;

namespace AccessModiFiersDemoApsd
{
    class Program
    {
        static void Main(string[] args)
        {
            cow c1 = new cow();
            Console.WriteLine(c1.legs);
            //Console.WriteLine(c1.color);
            c1.show();
            Console.WriteLine("I am Internal and access in Main "+c1.MyNumber);
            Console.ReadKey();
        }
    }
    class animal
    {
       protected string color = "white";
       internal int MyNumber = 23;
        
    }
    class cow : animal
    {
       public int legs = 4;
        public void show()
        {
            Console.WriteLine("Cow is "+color);
            Console.WriteLine("I am Internal and access in Derived class " + MyNumber);

        }
    }
}
