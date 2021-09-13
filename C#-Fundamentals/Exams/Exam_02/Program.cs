using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Exam_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> genres = Console.ReadLine().Split(" | ").ToList();
            string input = Console.ReadLine();

            while (input != "Stop!")
            {
                string[] command = input.Split(" ");
                string action = command[0];

                if (action == "Join")
                {
                    string index = command[1];
                    bool isInList = genres.Contains(index);

                    if (!isInList)
                    {
                        genres.Add(index);
                    }
                }
                else if (action == "Drop")
                {
                    string index = command[1];
                    bool isInList = genres.Contains(index);

                    if (isInList)
                    {
                        genres.Remove(index);
                    }
                }
                else if (action == "Replace")
                {
                    string index1 = command[1];
                    string index2 = command[2];

                    bool isInListFirst = genres.Contains(index1);
                    bool isInListSecond = genres.Contains(index2);

                    if (isInListFirst == true && isInListSecond == false)
                    {
                        int oldIndex = genres.IndexOf(index1);
                        genres.Remove(index1);
                        genres.Insert(oldIndex, index2);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", genres));
        }
    }
}
