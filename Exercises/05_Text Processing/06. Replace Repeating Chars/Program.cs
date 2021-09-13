using System;
using System.Text;
using System.Linq;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine());


            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                int indexes = 0;
                
                for (int j = i + 1; j <= input.Length - 1; j++)
                {
                    if (symbol == input[j])
                    {
                        indexes++;
                    }
                    else
                    {
                        break;
                    }
                }

                input = input.Remove(i + 1, indexes);
            }

            Console.WriteLine(input);
        }
    }
}
