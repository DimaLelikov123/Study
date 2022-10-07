using System;

namespace HomeTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1 : ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 : ");
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 : ");
            double x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 : ");
            double y2 = Convert.ToInt32(Console.ReadLine());

            double a1 = Math.Abs(Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)));
            Console.WriteLine("Module a1 = " + a1);

            double a2 = Math.Abs(Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)));
            Console.WriteLine("Module a2 = " + a2);
        }
    }
}
