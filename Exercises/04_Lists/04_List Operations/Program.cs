using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split(" ");

                if (command[0] == "Add")
                {
                    int index = int.Parse(command[1]);
                    numbers.Add(index);
                    input = Console.ReadLine();
                    continue;
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    int element = int.Parse(command[1]);

                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }

                    numbers.Insert(index, element);
                    input = Console.ReadLine();
                    continue;
                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);

                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }
                    numbers.RemoveAt(index);
                    input = Console.ReadLine();
                    continue;
                }
                else if (command[0] == "Shift" && command[1] == "left")
                {
                    int index = int.Parse(command[2]);

                    for (int i = 0; i < index; i++)
                    {
                        int temp = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(temp);
                    }
                    input = Console.ReadLine();
                    continue;
                }
                else if (command[0] == "Shift" && command[1] == "right")
                {
                    int index = int.Parse(command[2]);

                    for (int i = 0; i < index; i++)
                    {
                        int temp = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, temp);
                    }
                    input = Console.ReadLine();
                    continue;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
