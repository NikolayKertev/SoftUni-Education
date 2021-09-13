using System;

namespace Factoriel_Divider
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = int.Parse(Console.ReadLine());
            decimal b = int.Parse(Console.ReadLine());

            decimal facA = facSum(a);
            decimal facB = facSum(b);

            decimal output = factorielDivider(facA, facB);
            Console.WriteLine($"{output:f2}");
        }

        private static decimal factorielDivider(decimal x, decimal y)
        {
            return x / y;
        }

        private static decimal facSum(decimal x)
        {
            decimal counter = x;
            decimal sumFac = 1;

            for (int i = 1; i <= x; i++)
            {
                sumFac *= counter;
                counter--;
            }
            return sumFac;
        }
    }
}
