using System;

namespace _03_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            if (peopleCount < capacity)
            {
                Console.WriteLine("1");

            }
            else if (peopleCount % capacity == 0)
            {
                Console.WriteLine(peopleCount / capacity);
            }
            else
            {
                Console.WriteLine($"{peopleCount / capacity + 1}");
            }
        }
    }
}
