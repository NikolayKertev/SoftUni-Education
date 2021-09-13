using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int startIndex = 0;
            int index = 0;

            while (true)
            {
                if (input.IndexOf('\\', startIndex) == -1)
                {
                    break;
                }

                index = input.IndexOf('\\', startIndex);
                startIndex = index + 1;
            }

            input = input.Substring(index + 1, input.Length - index - 1);

            startIndex = 0;

            while (true)
            {
                if (input.IndexOf('.', startIndex) == -1)
                {
                    break;
                }

                index = input.IndexOf('.', startIndex);
                startIndex = index + 1;
            }

            string extension = input.Substring(index + 1, input.Length - index - 1);
            string name = input.Substring(0, index);

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
