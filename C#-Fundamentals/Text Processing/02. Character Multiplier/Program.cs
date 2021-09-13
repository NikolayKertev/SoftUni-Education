using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int length = 0;
            int sum = 0;

            if (input[0].Length <= input[1].Length)
            {
                length = input[0].Length;
            }
            else
            {
                length = input[1].Length;
            }

            string str1 = input[0];
            string str2 = input[1];

            List<char> firstNumber = str1.ToCharArray().ToList();
            List<char> secondNumber = str2.ToCharArray().ToList();

            for (int i = 0; i < length; )
            {
                sum += firstNumber[i] * secondNumber[i];
                firstNumber.RemoveAt(i);
                secondNumber.RemoveAt(i);
                length--;
            }

            if (str1.Length > str2.Length)
            {
                foreach (var item in firstNumber)
                {
                    sum += item;
                }
            }
            else if (str2.Length > str1.Length)
            {
                foreach (var item in secondNumber)
                {
                    sum += item;
                }
            }

            Console.WriteLine(sum);
        }
    }
}