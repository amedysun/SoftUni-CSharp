﻿using System;
using System.Globalization;

namespace _07.TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            int price = 0;
            if (age < 0)
            {
                Console.WriteLine("Error!");
                return;
            }

            if (day == "weekday")
            {
                if (0 <= age && age <= 18 || 64 < age && age <= 122)
                {
                    price = 12;
                }
                else if (18 < age && age <= 64)
                {
                    price = 18;
                }

            }
            else if (day == "weekend")
            {
                if (0 <= age && age <= 18 || 64 < age && age <= 122)
                {
                    price = 15;
                }
                else if (18 < age && age <= 64)
                {
                    price = 20;
                }
            }
            else if (day == "holiday")
            {
                if (0 <= age && age <= 18)
                {
                    price = 5;
                }
                else if (18 < age && age <= 64)
                {
                    price = 10;
                }
                else if (64 < age && age <= 122)
                {
                    price = 12;
                }
            }
            if (price > 0)
            {
                Console.WriteLine(price + "$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
