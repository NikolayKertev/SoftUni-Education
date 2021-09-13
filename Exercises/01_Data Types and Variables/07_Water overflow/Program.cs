using System;

namespace _07_Water_overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int capacity = 255;
            int n = int.Parse(Console.ReadLine());
            int totalWater = 0;

            while (n > 0)
            {

                int water = int.Parse(Console.ReadLine());

                n--;

                if (totalWater + water > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                totalWater += water;
            }

            Console.WriteLine(totalWater);
        }
    }
}
