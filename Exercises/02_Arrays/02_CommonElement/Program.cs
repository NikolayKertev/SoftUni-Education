﻿using System;

namespace _02_CommonElement
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(" ");
            string[] secondArray = Console.ReadLine().Split(" ");

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (firstArray[j] == secondArray[i])
                    {
                        Console.Write(firstArray[j] + " ");
                    }
                }
            }
        }
    }
}
