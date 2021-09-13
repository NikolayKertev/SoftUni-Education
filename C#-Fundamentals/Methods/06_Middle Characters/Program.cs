using System;

namespace _06_Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = MiddleCharacters(input);

            Console.WriteLine(result);
        }

        static string MiddleCharacters(string input)
        {
            string result;

            if (input.Length % 2 == 0)
            {
                result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2];
            }
            else
            {
                result = input[input.Length / 2].ToString();
            }

            return result;
        }
    }
}
