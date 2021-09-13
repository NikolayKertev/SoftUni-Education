using System;

namespace Beer_and_chips
{
    class Program
    {
        static void Main(string[] args)
        {
            const double beerPrice = 1.20;

            string fanName = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beerCount = int.Parse(Console.ReadLine());
            int chipsCount = int.Parse(Console.ReadLine());

            double totalBeerPrice = beerPrice *  beerCount;
            double chipsPrice = totalBeerPrice * 0.45;
            double totalChipsPrice = Math.Ceiling(chipsPrice * chipsCount);
            double totalMoneyNeeded = totalBeerPrice + totalChipsPrice;
            

            if (totalMoneyNeeded > budget)
            {
                Console.WriteLine($"{fanName} needs {totalMoneyNeeded - budget:f2} more leva!");
            }
            else
            {
                Console.WriteLine($"{fanName} bought a snack and has {budget - totalMoneyNeeded:f2} leva left.");
            }
        }
    }
}
