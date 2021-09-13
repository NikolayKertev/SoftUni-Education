using System;

namespace _02_Vowels_count
{
    class Program
    {
        static void Main(string[] args)
        {
            // a, e, i, o, u, and sometimes y.
            string input = Console.ReadLine();
            int result = VowelCounter(input);
            Console.WriteLine(result);
        }

        static int VowelCounter(string input)
        {
            string[] vowels = { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U", "y", "Y" };
            int counter = 0;

            for (int i = 0; i < vowels.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j].ToString() == vowels[i])
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
