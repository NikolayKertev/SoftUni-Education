using System;

namespace Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            int locationNumber = int.Parse(Console.ReadLine());
            double totalGoldMined = 0;
            int days = 0;

            for (int i = 1; i <= locationNumber; i++)
            {
                double expectedGold = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());

                for (int n = 0; n < days; n++)
                {
                    double goldMined = double.Parse(Console.ReadLine());
                    totalGoldMined += goldMined;
                }

                double averageGoldMined = totalGoldMined / days;
                double goldDif = expectedGold - averageGoldMined;
                totalGoldMined = 0;

                if (averageGoldMined < expectedGold)
                {
                    Console.WriteLine($"You need {goldDif:F2} gold.");
                }
                else
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageGoldMined:F2}.");
                }
            }
        }
    }
}
