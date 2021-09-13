using System;

namespace _01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sum += input;
                wagons[i] = input;
            }

            Console.WriteLine(String.Join(" ", wagons));
            Console.WriteLine(sum);
        }
    }
}
