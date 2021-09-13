using System;
using System.Numerics;

namespace _11_Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int bestSnow = 0;
            int bestTime = 0;
            BigInteger mostValue = 0;
            int mostQuality = 0;
            BigInteger value = 0;

            for (int i = 0; i < N; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                value = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (value > mostValue)
                {
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    mostValue = value;
                    mostQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{bestSnow} : {bestTime} = {mostValue} ({mostQuality})");
        }
    }
}
