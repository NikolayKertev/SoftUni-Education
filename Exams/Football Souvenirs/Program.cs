using System;

namespace Football_Souvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string souvenirType = Console.ReadLine();
            int souvenirCount = int.Parse(Console.ReadLine());

            double flagsPrice = 0;
            double capsPrice = 0;
            double postersPrice = 0;
            double stickersPrice = 0;

            double totalMoney = 0;

            switch (country)
            {
                case "Argentina":
                    flagsPrice = 3.25;
                    capsPrice = 7.2;
                    postersPrice = 5.1;
                    stickersPrice = 1.25;
                    break;
                case "Brazil":
                    flagsPrice = 4.2;
                    capsPrice = 8.5;
                    postersPrice = 5.35;
                    stickersPrice = 1.2;
                    break;
                case "Croatia":
                    flagsPrice = 2.75;
                    capsPrice = 6.9;
                    postersPrice = 4.95;
                    stickersPrice = 1.1;
                    break;
                case "Denmark":
                    flagsPrice = 3.1;
                    capsPrice = 6.5;
                    postersPrice = 4.8;
                    stickersPrice = 0.9;
                    break;
            }

            switch (souvenirType)
            {
                case "flags":
                    totalMoney = souvenirCount * flagsPrice;
                    break;
                case "caps":
                    totalMoney = souvenirCount * capsPrice;
                    break;
                case "posters":
                    totalMoney = souvenirCount * postersPrice;
                    break;
                case "stickers":
                    totalMoney = souvenirCount * stickersPrice;
                    break;
            }

            if (country == "Argentina" || country == "Brazil" || country == "Croatia" || country == "Denmark")
            {
                if (souvenirType == "flags" || souvenirType == "caps" || souvenirType == "posters" || souvenirType == "stickers")
                {
                    Console.WriteLine($"Pepi bought {souvenirCount} {souvenirType} of {country} for {totalMoney:f2} lv.");
                }
                else 
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else
            {
                Console.WriteLine("Invalid country!");
            }
        }
    }
}
