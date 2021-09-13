using System;

namespace Puppy_Care
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodAmountInKGs = 1000 * int.Parse(Console.ReadLine());
            int foodNeeded = 0;
            string foodPerDay = " ";

            for (int i = 0; ; i++)
            {
                foodPerDay = Console.ReadLine();
                if (foodPerDay == "Adopted")
                {
                    break;
                }
                int foodDay = 0;
                Int32.TryParse(foodPerDay, out foodDay);
                foodNeeded += foodDay;
            }

            if (foodNeeded > foodAmountInKGs)
            {
                Console.WriteLine($"Food is not enough. You need {foodNeeded - foodAmountInKGs} grams more.");
            }
            else
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodAmountInKGs - foodNeeded} grams.");
            }
        }
    }
}
