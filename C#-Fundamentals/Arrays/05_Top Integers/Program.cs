using System;
using System.Linq;

namespace _05_Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            // array for the input
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            // array so we can transfer the data and work with it
            int[] tempArray = new int[array.Length];
            // boolean to check if its "Top" integer
            bool isTop = false;
            // counter
            int counter = 0;

            //for cycle to check each of the integers
            for (int j = 0; j < array.Length; j++)
            {
                // boolean, checks if main for cycle is completed
                bool isCompleted = false;

                // here we check if the main cycle is completed
                if (j == array.Length - 1)
                {
                    isCompleted = true;
                }

                // second for cycle
                for (int i = j + 1; i < array.Length; i++)
                    // we compare a number to all of the numbers to the right
                    if (array[j] > array[i])
                    {
                        isTop = true;
                    }
                // if one of the numbers to the right is bigger, it is useless to continue so we "break"
                // the cycle and continue with the next number
                    else
                    {
                        isTop = false;
                        break;
                    }
                // we check if it's either "Top" integer or a last number, last number cannot be compared to anything right of it cause
                // it's the last one, so it's always a "Top" integer
                if (isTop == true || isCompleted == true)
                {
                    // if it's true, we add the number to the temp array, the counter starts from 0 and counts each number we have added.
                    tempArray[counter] = array[j];
                    counter++;
                }
            }

            // new array to print the result, has lenght "counter" (i did that because i cannot know how many "Top" integers we might 
            // have, they might be 20, they might be 2, therefore i created a temp array long enough to fit all of the main array numbers
            // and another array with the lenght of how many Top integers i have, after i know them of course.
            int[] printArray = new int[counter];
            // for cycle to aquire each of the elements to the printArray
            for (int i = 0; i < counter; i++)
            {
                printArray[i] = tempArray[i];
            }
            // printing the array (if you try to print "tempArray" and its lenght is lets say 5, but there are only 2 "Top" integers
            // you would get as a result something like this :
            // X Y 0 0 0 
            // where X and Y are numbers
            Console.WriteLine(String.Join(" ", printArray));
        }
    }
}
