using System;

namespace _01_Smallest_of_three_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = Min(a, b, c);
            Console.WriteLine(result);
        }

        static int Min(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }
    }
}
