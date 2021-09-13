using System;
using System.Linq;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder encryptedInput = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                symbol += (char)3;
                encryptedInput.Append(symbol);
            }

            Console.WriteLine(encryptedInput);
        }
    }
}
