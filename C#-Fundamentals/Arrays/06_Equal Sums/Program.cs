using System;
using System.Linq;

namespace _06_Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            long leftSum = 0;
            long rightSum = 0;
            int index = 0;
            bool isEqual = false;
            int counter = 0;

            if (numbers.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                leftSum += numbers[i];
                counter++;

                for (int j = i + 2; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                if (leftSum == rightSum && numbers.Length > 2)
                {
                    isEqual = true;
                    index = counter;
                    Console.WriteLine(counter);
                    break;
                }
                else
                {
                    rightSum = 0;
                    isEqual = false;
                }
            }


            if (isEqual == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
