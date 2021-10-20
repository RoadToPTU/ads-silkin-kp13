using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            double a;
            double b;
            if (z == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                a = Math.Cos(x + x * y / z);
                if (Math.Cos(a) == 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    b = Math.Pow(x, 3)/Math.Cos(a);
                    Console.WriteLine("a = " + a);
                    Console.WriteLine("b = " + b);
                }
                
            }
           
            
        }
    }
}
