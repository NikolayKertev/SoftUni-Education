using System;
using System.Linq;

namespace Password_hack
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string[] generatedPassword = new string[password.Length];
            string newPassword = "";

            while (newPassword != password)
            {
                int counter = 0;
                string checker = password[counter].ToString();

                for (int i = 0; i < 10; i++)
                {
                    if (checker == i.ToString())
                    {
                        generatedPassword[counter] = i.ToString();
                        newPassword += generatedPassword[counter];
                        counter++;
                        break;
                    }
                }

                checker = password[counter].ToString();

                for (int j = 0; j < 10; j++)
                {
                    if (checker == j.ToString())
                    {
                        generatedPassword[counter] = j.ToString();
                        newPassword += generatedPassword[counter];
                        counter++;
                        break;
                    }
                }

                checker = password[counter].ToString();

                for (int k = 0; k < 10; k++)
                {
                    if (checker == k.ToString())
                    {
                        generatedPassword[counter] = k.ToString();
                        newPassword += generatedPassword[counter];
                        counter++;
                        break;
                    }
                }
            }

            Console.WriteLine(newPassword);
        }
    }
}
