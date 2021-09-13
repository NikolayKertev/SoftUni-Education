using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal totalSum = 0;
            Regex regex = new Regex(@"^%(?<name>[A-z][a-z]+)%[^\|\$\%\.]*?<(?<product>\w+)>[^\|\$\%\.]*?\|(?<amount>[0-9]+)\|[^\|\$\%\.]*?(?<price>[0-9]+\.*[0-9]*)\$$");

            while (input != "end of shift")
            {
                bool validated = regex.IsMatch(input);

                if (validated)
                {
                    var matches = regex.Matches(input);
                    decimal sum = 0;
                    decimal price = decimal.Parse(matches[0].Groups["price"].ToString());
                    int amount = int.Parse(matches[0].Groups["amount"].ToString());
                    sum += price * amount;
                    totalSum += sum;

                    Console.WriteLine($"{matches[0].Groups["name"]}: {matches[0].Groups["product"]} - {sum:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}
