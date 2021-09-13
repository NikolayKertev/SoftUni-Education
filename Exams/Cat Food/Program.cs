using System;

namespace Cat_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            const double kgFood = 12.45;

            int catCount = int.Parse(Console.ReadLine());

            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int sumGroup1 = 0;
            int sumGroup2 = 0;
            int sumGroup3 = 0;

            for (int i = 1; i <= catCount; i++)
            {
                int foodAmount = int.Parse(Console.ReadLine());

                if (foodAmount<200)
                {
                    group1++;
                    sumGroup1 += foodAmount;
                }
                else if (foodAmount < 300)
                {
                    group2++;
                    sumGroup2 += foodAmount;
                }
                else if (foodAmount < 400)
                {
                    group3++;
                    sumGroup3 += foodAmount;
                }
            }

            double totalSum = (sumGroup1 + sumGroup2 + sumGroup3)*1.0 / 1000 * kgFood;
            Console.WriteLine($"Group 1: {group1} cats.");
            Console.WriteLine($"Group 2: {group2} cats.");
            Console.WriteLine($"Group 3: {group3} cats.");
            Console.WriteLine($"Price for food per day: {totalSum:f2} lv.");

        }
    }
}
