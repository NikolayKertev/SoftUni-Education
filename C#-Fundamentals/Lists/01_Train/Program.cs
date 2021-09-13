using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int maxCap = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input.Split(" ");

                if (command[0] == "Add")
                {
                    int index = int.Parse(command[1]);
                    wagons.Add(index);
                }
                else
                {
                    int index = int.Parse(command[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (index + wagons[i] <= maxCap)
                        {
                            wagons[i] += index;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
