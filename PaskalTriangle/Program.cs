using System;

namespace PaskalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 1000;
            int n;
            Console.Write("Enter the quantity of the Pascal's triangle: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            int previous = 1, current = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                    Console.Write(" ");

                previous = 1;
                if (i > 0)
                    Console.Write(" " + arr[0]);
                for (int j = 1; j < i; j++)
                {
                    current = arr[j];
                    arr[j] += previous;
                    previous = current;
                    Console.Write(" " + arr[j]);
                }

                arr[i] = 1;
                Console.Write(" " + arr[i]);

                Console.WriteLine();
            }
        }
    }
}
