using System;


namespace demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name = "Apsd Innovation infotech 123 0.123";
            // Console.WriteLine(name.Substring(name.IndexOf(" ")+1),name.LastIndexOf(" "));
            //Console.WriteLine("Hello World");
            //int firstNum = Convert.ToInt32(Console.ReadLine());
            //int secNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(firstNum + secNum);
            //string[] subname = name.Split(' ');
            //for(int i = 0; i < subname.Length; i++)
            //{
            //    Console.WriteLine(subname[i]);
            //}

            /*for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]+" ");
                
            }*/
            /*Console.WriteLine("Enter any number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    int temp = num * i;
                    if (temp % 2 == 0)
                    {
                        Console.WriteLine(temp);
                    }
                }
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    int temp = num * i;
                    if (temp % 2 != 0)
                    {
                        Console.WriteLine(temp);
                    }
                }
            }   */
            Rectangle rectangle = new Rectangle();
            rectangle.getValue();
            rectangle.displayArea();
            Console.ReadKey();
        }
        class Rectangle
        {
            double height;
            double width;
            public void getValue()
            {
                Console.WriteLine("Enter the height");
                height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the width");
                width = Convert.ToDouble(Console.ReadLine());
            }
            public double CalculateArea(double height,double width)
            {
                double area = height * width;
                return area;
            }
            public void displayArea()
            {
                Console.WriteLine("Area is :" + CalculateArea(height, width));
            }
        }
    }
}
