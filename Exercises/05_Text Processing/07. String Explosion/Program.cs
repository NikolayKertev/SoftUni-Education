using System;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char symbul;
            int explosions = 0;

            for (int i = 0; i < input.Length; i++)
            {
                symbul = input[i];

                if (symbul == '>')
                {
                    explosions += int.Parse(input[i + 1].ToString());
                }

                while(explosions != 0)
                {
                    if (i == input.Length - 1)
                    {
                        break;
                    }
                    int indexToREmove = i + 1;

                    if (input[indexToREmove] == '>')
                    {
                        break;
                    }

                    input = input.Remove(indexToREmove, 1);
                    explosions--;
                }
            }

            Console.WriteLine(input);
        }
    }
}
