using System;
using System.Text.RegularExpressions;

namespace _02.Final_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;
            Regex regex = new Regex(@"^(?<exp>[$%])(?<tag>[A-Z][a-z]{2,})\k<exp>: (\[(?<number1>\d+)\]\|)(\[(?<number2>\d+)\]\|)(\[(?<number3>\d+)\]\|)$");

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                
                if (regex.IsMatch(input))
                {
                    string numbers = string.Empty;
                    var matches = regex.Matches(input);
                    string decrypted = string.Empty;

                    foreach (Match match in matches)
                    {
                        numbers = match.Groups["number1"].ToString() + " ";
                        numbers += match.Groups["number2"].ToString() + " ";
                        numbers += match.Groups["number3"].ToString();
                    }

                    string[] numberArray = numbers.Split(" ");
                    for (int j = 0; j < numberArray.Length; j++)
                    {
                        char symbol = (char)int.Parse(numberArray[j]);
                        decrypted += symbol.ToString();
                    }

                    foreach (Match match in matches)
                    {
                        Console.WriteLine($"{match.Groups["tag"]}: {decrypted}");
                    }

                }
                else
                {
                    Console.WriteLine($"Valid message not found!");
                }
            }
        }
    }
}
