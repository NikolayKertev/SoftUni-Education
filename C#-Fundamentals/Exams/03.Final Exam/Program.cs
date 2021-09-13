using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Final_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> liked = new Dictionary<string, List<string>>();
            int unliked = 0;

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] arg = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string guest = arg[1];
                string meal = arg[2];

                if (input.Contains("Like"))
                {
                    if (!liked.ContainsKey(guest))
                    {
                        liked.Add(guest, new List<string>());
                    }

                    if (liked[guest].Contains(meal))
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    liked[guest].Add(meal);
                    liked[guest].Sort();
                }
                else if (input.Contains("Unlike"))
                {
                    if (!liked.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                        input = Console.ReadLine();
                        continue;
                    }

                    if (!liked[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        input = Console.ReadLine();
                        continue;
                    }

                    liked[guest].Remove(meal);
                    unliked++;
                    Console.WriteLine($"{guest} doesn't like the {meal}.");
                }

                input = Console.ReadLine();
            }

            liked = liked.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var (key, value) in liked)
            {
                int counter = 0;
                Console.Write($"{key}: ");
                foreach (var item in value)
                {
                    if (counter != 0)
                    {
                        Console.Write(", ");
                    }
                    counter++;
                    Console.Write(item);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Unliked meals: {unliked}");
        }
    }
}
