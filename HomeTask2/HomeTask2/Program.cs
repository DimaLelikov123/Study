using System;

namespace HomeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a side = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b side = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c side = ");
            double c = Convert.ToDouble(Console.ReadLine());

            double p = (a + b + c) / 2;
          
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Square of triangle = " + S);
        }
    }
}
