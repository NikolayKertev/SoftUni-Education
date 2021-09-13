using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(", ");
            Dictionary<string, int> racers = new Dictionary<string, int>();

            foreach (var item in inputArray)
            {
                racers.Add(item, 0);
            }

            Regex nameRegex = new Regex(@"[A-Za-z]");
            Regex numberRegex = new Regex(@"[0-9]");

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = string.Empty;
                int sum = 0;
                var nameCollection = nameRegex.Matches(input);
                var numberCollection = numberRegex.Matches(input);

                foreach (Match match in nameCollection)
                {
                    name += match;
                }
                foreach (Match match in numberCollection)
                {
                    sum += int.Parse(match.ToString());
                }

                if (racers.ContainsKey(name))
                {
                    racers[name] += sum;
                }

                input = Console.ReadLine();
            }

            var sorted = racers.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            int counter = 1;

            foreach (var item in sorted)
            {
                if (counter > 3)
                {
                    break;
                }

                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
                counter++;
            }
        }
    }
}
