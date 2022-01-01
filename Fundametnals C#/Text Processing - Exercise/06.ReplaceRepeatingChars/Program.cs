﻿using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var sb = new StringBuilder();

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] != text[i + 1])
                {
                    sb.Append(text[i]);
                }
            }
            var symbol = text[text.Length - 1];
            sb.Append(symbol);  
            Console.WriteLine(sb);
        }
    }
}
