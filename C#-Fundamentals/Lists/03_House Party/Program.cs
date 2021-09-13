using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < guests; i++)
            {
                string input = Console.ReadLine();
                string[] command = input.Split();

                string index = command[2];

                if (index == "going!")
                {
                    bool isInList = true;
                    foreach (var name in names)
                    {
                        if (name == command[0])
                        {
                            Console.WriteLine($"{command[0]} is already in the list!");
                            isInList = false;
                            break;
                        }

                    }
                    if (isInList == true)
                    {
                        names.Add(command[0]);
                    }

                }
                else if (index == "not")
                {
                    if (!(names.Remove(command[0])))
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }

                }
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
