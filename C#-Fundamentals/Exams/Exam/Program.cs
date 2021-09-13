using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"^(\$|%)([A-Z][a-z]{2,})\1: [?<firstNumber>[0-9]+]\|[?<secondNumber>[0-9]+]\|[?<thirdNumber>[0-9]+]\|$";
                var digits = Regex.Match(input, pattern);
                string word = string.Empty;
                //$Dsdasdasd$: [123]|[123]|[123]|
                if (!digits.Success)
                {
                    Console.WriteLine("Valid message not found!");
                    continue;
                }
                else
                {
                    var matches = Regex.Matches(input, pattern);
                    string text = string.Empty;

                    foreach (Match match in matches)
                    {
                        text = match.Groups["firstNumber"].ToString() + " ";
                        text += match.Groups["secondNumber"].ToString() + " ";
                        text += match.Groups["thirdNumber"].ToString();
                    }



                    Console.WriteLine($"Request: {text}");
                }
            }
        }
    }
}