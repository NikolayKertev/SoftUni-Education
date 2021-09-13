using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "Finish")
            {
                string[] arg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = arg[0];

                if (action == "Replace")
                {
                    text.Replace(arg[1], arg[2]);
                    Console.WriteLine(text);
                }
                else if (action == "Cut")
                {
                    int start = int.Parse(arg[1]);
                    int end = int.Parse(arg[2]);

                    if (text.Length < end || text.Length < start || start < 0)
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                    else
                    {
                        text.Remove(start, end - start + 1);
                        Console.WriteLine(text);
                    }
                }
                else if (action == "Make")
                {
                    string actionType = arg[1];
                    if (actionType == "Upper")
                    {
                        var currentText = text.ToString().ToUpper();
                        text.Remove(0, text.Length);
                        text.Append(currentText);
                        Console.WriteLine(text);
                    }
                    else if (actionType == "Lower")
                    {
                        var currentText = text.ToString().ToLower();
                        text.Remove(0, text.Length);
                        text.Append(currentText);
                        Console.WriteLine(text);
                    }
                }
                else if (action == "Check")
                {
                    var currentText = text.ToString();
                    if (currentText.Contains(arg[1]))
                    {
                        Console.WriteLine($"Message contains {arg[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {arg[1]}");
                    }
                }
                else if (action == "Sum")
                {
                    int start = int.Parse(arg[1]);
                    int end = int.Parse(arg[2]);

                    if (text.Length < end || text.Length < start || start < 0)
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                    else
                    {
                        string currentText = text.ToString();
                        currentText = currentText.Substring(start, end - start + 1);
                        int sum = 0;

                        for (int i = 0; i < currentText.Length; i++)
                        {
                            sum += currentText[i];
                        }

                        Console.WriteLine(sum);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
