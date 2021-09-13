using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Trim().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> output = new List<string>();
            List<string> result = new List<string>();

            input.Reverse();

            for (int i = 0; i < input.Count; i++)
            {
                output = input[i].Split(" ").ToList();
        
                for (int j = 0; j < output.Count; j++)
                {
                    if (output[j] == null || output[j] == string.Empty)
                    {
                        continue;
                    }
                    result.Add(output[j]);
                }
            }
            
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
