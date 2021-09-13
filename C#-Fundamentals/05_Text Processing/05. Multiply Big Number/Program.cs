using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            int add = 0;

            StringBuilder result = new StringBuilder();

            if (secondNumber == 0)
            {
                result.Insert(0, 0);
                Console.WriteLine(result);
                return;
            }

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                int sum = 0;
                int digit = int.Parse(firstNumber[i].ToString());

                if (add != 0)
                {
                    sum = digit * secondNumber + add;

                    add = sum / 10;
                    sum = sum % 10;
                    result.Insert(0, sum);
                    continue;
                }

                sum = digit * secondNumber;

                add = sum / 10;
                sum = sum % 10;

                result.Insert(0, sum);
            }
            if (add != 0)
            {
                result.Insert(0, add);
            }

            Console.WriteLine(result);
        }
    }
}
