using System;

namespace _03_Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            CharsInRange(char1, char2);

        }

        static void CharsInRange(char a, char b)
        {
            if ((int)a > (int)b)
            {
                char temp = a;
                a = b;
                b = temp;
            }

            for (int i = a + 1; i < b; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
