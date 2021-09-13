using System;

namespace Polyndrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            isPolyndrome(input);
        }

        static void isPolyndrome(string input)
        {
            while (input != "END")
            {
                for (int i = 0; i <= input.Length / 2; i++)
                {
                    if (input.Length < 2)
                    {
                        Console.WriteLine("True");
                        break;
                    }

                    if (input[i] == input[input.Length - 1 - i])
                    {
                        Console.WriteLine("true");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("false");
                        break;
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
