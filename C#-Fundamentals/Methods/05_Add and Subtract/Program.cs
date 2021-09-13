using System;

namespace Sum_And_Substract
{
    class Program
    {
        static void Main(string[] args)
        {
            int output = SubstractOfTwo();
            Console.WriteLine(output);
        }

        static int SubstractOfTwo()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int lastSum = SumOfTwo(a, b) - c;

            return lastSum;
        }

        static int SumOfTwo(int a, int b)
        {
            int Sum = a + b;
            return Sum;
        }
    }
}
