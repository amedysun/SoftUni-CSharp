﻿using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            switch (comand)
            {
                case "add":
                    Add(a, b);
                    break;
                case "divide":
                    Divide(a, b);
                    break;
                case "multiply":
                    Multiply(a, b);
                    break;
                case "subtract":
                    Subtract(a,b);
                    break;

            }
        }
        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Multiply(int a,int b)
        {
            Console.WriteLine(a * b);
        }
        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}
