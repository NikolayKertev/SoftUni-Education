using System;
using System.Linq;

namespace _07_MaxSeqyebce_if_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int counter = 0;
            int maxCounter = 0;
            int currentSymbol = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                }

                if (counter > maxCounter)
                {
                    currentSymbol = numbers[i];
                    maxCounter = counter;
                }
            }

            for (int i = 0; i <= maxCounter; i++)
            {
                if (!(maxCounter == 0))
                {
                    Console.Write(currentSymbol + " ");
                }
                else
                {
                    Console.WriteLine(numbers[0]);
                }

            }
        }
    }
}
