using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split("|").ToList();

            string input = Console.ReadLine();

            while (input != "Shop!")
            {
                string[] command = input.Split("%");
                string action = command[0];

                if (action == "Important")
                {
                    string index = command[1];
                    bool isInList = products.Contains(index);

                    if (isInList)
                    {
                        products.Remove(index);
                        products.Insert(0, index);
                    }
                    else
                    {
                        products.Insert(0, index);
                    }
                }
                else if (action == "Add")
                {
                    string index = command[1];
                    bool isInList = products.Contains(index);

                    if (isInList)
                    {
                        Console.WriteLine("The product is already in the list.");
                    }
                    else
                    {
                        products.Add(index);
                    }
                }
                else if (action == "Swap")
                {
                    string input1 = command[1];
                    string input2 = command[2];

                    bool isInListFirst = products.Contains(input1);
                    bool isInListSecond = products.Contains(input2);

                    if (isInListFirst == true && isInListSecond == true)
                    {
                        int firstIndex = products.IndexOf(input1);
                        int secondIndex = products.IndexOf(input2);

                        products.RemoveAt(firstIndex);
                        products.Insert(firstIndex, input2);

                        products.RemoveAt(secondIndex);
                        products.Insert(secondIndex, input1);
                    }
                    else if (isInListFirst == false)
                    {
                        {
                            Console.WriteLine($"Product {input1} missing!");
                        }
                    }
                    else if (isInListSecond == false)
                    {
                        {
                            Console.WriteLine($"Product {input2} missing!");
                        }
                    }
                }
                else if (action == "Remove")
                {
                    string index = command[1];
                    bool isInList = products.Contains(index);

                    if (!isInList)
                    {
                        Console.WriteLine($"Product {index} isn't in the list.");
                    }
                    else
                    {
                        products.Remove(index);
                    }
                }
                else if (action == "Reversed")
                {
                    products.Reverse();
                }

                input = Console.ReadLine();
            }

            int counter = 1;

            foreach (var item in products)
            {
                Console.WriteLine($"{counter}. {item}");
                counter++;
            }
        }
    }
}
