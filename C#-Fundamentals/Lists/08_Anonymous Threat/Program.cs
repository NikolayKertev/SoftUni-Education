using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace _08_Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] commands = input.Split();

                string action = commands[0];

                if (action == "merge")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    string mergedText = string.Empty;
                    int counter = 0;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (endIndex >= text.Count)
                    {
                        endIndex = text.Count - 1;
                    }

                    for (int i = startIndex; i <= endIndex; i++)
                    {

                        mergedText += text[i];
                        counter++;
                    }
                    if (startIndex > text.Count)
                    {

                    }
                    else
                    {
                        text.RemoveRange(startIndex, counter);
                        text.Insert(startIndex, mergedText);
                    }
                }
                else if (action == "divide")
                {
                    int index = int.Parse(commands[1]);
                    int partitions = int.Parse(commands[2]);
                    string dividedText = string.Empty;
                    int counter = 1;

                    if (index >= text.Count || index < 0)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    for (int i = 0; i < partitions; i++)
                    {
                        string current = text[index];

                        if (partitions > current.Length)
                        {
                            break;
                        }

                        if (counter == partitions)
                        {
                            dividedText += text[index].Substring(i * (current.Length / partitions), current.Length / partitions) 
                                + text[index].Substring((i + 1) * ((current.Length - 1) / partitions), current.Length % partitions);
                            counter++;
                            continue;
                        }

                        dividedText += text[index].Substring(i * (current.Length / partitions), current.Length / partitions) + " ";
                        counter++;
                        int lenght = dividedText.Length;
                    }
                    text.RemoveAt(index);
                    text.Insert(index, dividedText);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", text));
        }
    }
}
