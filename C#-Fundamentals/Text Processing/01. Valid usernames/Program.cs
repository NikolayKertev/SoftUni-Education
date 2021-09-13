using System;

namespace _1._Valid_usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);


            foreach (var username in input)
            {
                bool isValid = true;

                if (username.Length < 3 || username.Length > 16)
                {
                    isValid = false;
                }

                for (int i = 0; i < username.Length; i++)
                {
                    char character = username[i];

                    if (!(char.IsLetterOrDigit(character) || character == '-' || character == '_'))
                    {
                        isValid = false;
                    }
                }

                if (isValid)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
