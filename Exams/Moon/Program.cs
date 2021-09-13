using System;

namespace _1st
{
    class Program
    {
        static void Main(string[] args)
        {
            const int range = 384400;
            const int stayTime = 3;

            double speed = double.Parse(Console.ReadLine());
            double fuelPer100KM = double.Parse(Console.ReadLine());

            double timeNeeded = Math.Ceiling(range * 2 / speed + 3);
            double fuelNeeded = fuelPer100KM * range * 2 / 100;

            Console.WriteLine($"{timeNeeded}");
            Console.WriteLine(fuelNeeded);
        }
    }
}
