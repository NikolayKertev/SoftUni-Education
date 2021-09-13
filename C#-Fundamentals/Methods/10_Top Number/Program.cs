using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;

            for (int i = 0; i < n; i++)
            {
                number = i;
                bool isTop = IsTop(n, number);

                if (isTop == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsDivisible(int number)
        {
            int sum = 0;
            int input = number;

            while (input > 0)
            {
                sum += input % 10;
                input = input / 10;
            }

            if (sum % 8 == 0 && number > 9)
            {
                return true;
            }

            return false;
        }

        static bool HasAtLeastOneDigit(int number)
        {
            int input = number;

            while (input > 0)
            {
                int n = input % 10;
                input = input / 10;

                if (!(n % 2 == 0))
                {
                    return true;
                }
            }

            return false;
        }

        static bool IsTop(int n, int number)
        {

            if (IsDivisible(number) && HasAtLeastOneDigit(number))
            {
                return true;
            }
            return false;
        }
    }
}
