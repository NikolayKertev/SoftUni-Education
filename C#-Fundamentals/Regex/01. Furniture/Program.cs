using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@">{2}(?<object>\w+)<<(?<price>\d+\.*\d*)!(?<amount>\d+)");
            StringBuilder inputs = new StringBuilder();

            while (input != "Purchase")
            {
                inputs.Append(input);

                input = Console.ReadLine();
            }

            var matches = regex.Matches(inputs.ToString());
            Console.WriteLine("Bought furniture:");
            decimal sum = 0;

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups["object"]);
                
                sum += decimal.Parse(match.Groups["price"].ToString()) * int.Parse(match.Groups["amount"].ToString());
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
