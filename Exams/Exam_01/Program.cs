using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            decimal flourPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal apronPrice = decimal.Parse(Console.ReadLine());

            decimal apronCount = Math.Ceiling(studentsCount * 1.2m);
            int eggsCount = studentsCount * 10;
            int flourCount = studentsCount - studentsCount / 5;

            decimal sum = apronPrice * apronCount + eggsCount * eggPrice + flourPrice * flourCount;

            if (budget >= sum)
            {
                Console.WriteLine($"Items purchased for {sum:f2}$.");
            }
            else
            {
                Console.WriteLine($"{sum - budget:f2}$ more needed.");
            }
        }
    }
}
