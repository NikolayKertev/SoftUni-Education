using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex firstRegex = new Regex(@"[SsTtAaRr]");
            Regex secondRegex = new Regex(@"[^\@\-\!\:\>]*@(?<planet>[A-Z][a-z0]*)[^\@\-\!\:\>]*:(?<population>[0-9]+)[^\@\-\!\:\>]*\!(?<attackType>[AD])\![^\@\-\!\:\>]*\-\>(?<soldiers>[0-9]+)[^\@\-\!\:\>]*");

            string text = String.Empty;

            var dict = new Dictionary<string, List<string>>();

            dict.Add("A", new List<string>());
            dict.Add("D", new List<string>());

            for (int i = 0; i < n; i++)
            {
                StringBuilder sb = new StringBuilder();

                string input = Console.ReadLine();

                var starCollection = firstRegex.Matches(input);
                int amount = starCollection.Count;

                for (int j = input.Length - 1; j >= 0; j--)
                {
                    char symbol = (char)(input[j] - amount);
                    sb.Insert(0, symbol);
                }

                text += sb;
            }

            var matches = secondRegex.Matches(text);

            foreach (Match match in matches)
            {
                dict[match.Groups["attackType"].ToString()].Add(match.Groups["planet"].ToString());
                dict[match.Groups["attackType"].ToString()].Sort();
            }

            int aCount = 0;
            int dCount = 0;

            foreach (var (key, value) in dict)
            {
                if (key == "A")
                {
                    aCount = value.Count;
                }
                else if (key == "D")
                {
                    dCount = value.Count;
                }
            }

            Console.WriteLine($"Attacked planets: {aCount}");
            foreach (var (key,value) in dict)
            {
                int i = 0;
                if (key == "D")
                {
                    continue;
                }
                while (i < value.Count)
                {
                    Console.WriteLine($"-> {value[i]}");
                    i++;
                }
            }

            Console.WriteLine($"Destroyed planets: {dCount}");
            foreach (var (key, value) in dict)
            {
                int i = 0;
                if (key == "A")
                {
                    continue;
                }
                while (i < value.Count)
                {
                    Console.WriteLine($"-> {value[i]}");
                    i++;
                }
                
            }

        }
    }
}
