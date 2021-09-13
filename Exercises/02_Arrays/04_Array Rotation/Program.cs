using System;
using System.Linq;

namespace _4_Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int current = 0;

            if (!(rotations % array.Length == 0))
            {
                for (int j = 0; j < rotations; j++)
                {
                    current = array[0];
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        array[i] = array[i + 1];
                    }
                    array[array.Length - 1] = current;
                }
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
