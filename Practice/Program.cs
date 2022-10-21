using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Завдання
            //Console.WriteLine("Please enter the high of pyramide");
            //int a = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < a; i++)
            //{
            //    for (int s = a - i; s > 0; s--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine();
            //}

            // 2 Завдання
            //int k;
            //do
            //{
            //    double M = Convert.ToDouble(Console.ReadLine());
            //    k = Convert.ToInt32(M * 100);
            //}
            //while (k <= 0);

            //int d = k / 25;
            //int l = (k % 25) / 10;
            //int j = ((k % 25) % 10) / 5;
            //int i = (((k % 25) % 10) % 5) / 1;
            //int sum = d + l + j + i;
            //Console.WriteLine(sum);

            // 3 Завдання
            //long n = Convert.ToInt64(Console.ReadLine()), a = 0, x2 = 0, asum = 0, x2p = 0, sum = 0, d2, m;
            //bool val;
            //while (n > 0)
            //{
            //    x2 = a;
            //    a = n % 10;
            //    if (asum % 2 == 0)
            //    {
            //        sum += a;
            //    }
            //    else
            //    {
            //        m = 2 * a;
            //        x2p += (m / 10) + (m % 10);
            //    }
            //    n /= 10;
            //    asum++;
            //}
            //val = (sum + x2p) % 10 == 0;
            //d2 = (a * 10) + x2;

            //if (a == 4 && asum >= 13 && asum <= 16 && val)
            //{
            //    Console.WriteLine("VISA");
            //}
            //else if (d2 >= 51 && d2 <= 55 && asum == 16 && val)
            //{
            //    Console.WriteLine("MASTERCARD");
            //}
            //else
            //{
            //    Console.WriteLine("INVALID");
            //}
        }
    }
}
