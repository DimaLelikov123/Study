using System;

namespace HomeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("third number : ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("fourth number : ");
            int d = Convert.ToInt32(Console.ReadLine());
            if (a < b && a < c && a < d)
            {
                Console.WriteLine("Minimum value is a = " + a);
            }
            else if(b < a && b < c && b < d)
            {
                Console.WriteLine("Minimum value is b = " + b);
            }
            else if(c < a && c < b && c < d)
            {
                Console.WriteLine("Minimum value is c = " + c);
            }
            else
            {
                Console.WriteLine("Minimum value is d = " + d);
            }
        }
    }
}
