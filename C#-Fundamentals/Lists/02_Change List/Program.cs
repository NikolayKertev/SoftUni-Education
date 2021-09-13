using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split(" ");

                if (command[0] == "Delete")
                {
                    int index = int.Parse(command[1]);

                    numbers.RemoveAll(x => x == index);
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    int element = int.Parse(command[1]);

                    numbers.Insert(index, element);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
