﻿using System;
using System.Linq;

namespace _08_Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sumInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == sumInput)
                    {
                        Console.Write(array[i] + " " + array[j]);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
