using System;

namespace _08_Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal mostVolume = 0;
            string biggest = "";
            string model = "";

            for (int i = 0; i < n; i++)
            {
                model = Console.ReadLine();
                decimal r = decimal.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                decimal volume = (decimal)Math.PI * (r * r * height);

                if (volume > mostVolume)
                {
                    mostVolume = volume;
                    biggest = model;
                }
            }

            Console.WriteLine(biggest);
        }
    }
}
