using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split();
            int specialNumber = int.Parse(input[0]);
            int power = int.Parse(input[1]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumber)
                {
                    for (int j = i - power; j <= i + power; j++)
                    {
                        if (j < 0 || j >= numbers.Count)
                        {
                            continue;
                        }

                        numbers[j] = 0;
                    }
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
