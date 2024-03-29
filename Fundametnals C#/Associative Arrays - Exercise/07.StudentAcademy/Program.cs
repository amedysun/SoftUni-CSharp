﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            Dictionary<string, double> avarageGradeOfStudents = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                List<double> studentGrades = new List<double> { grade };

                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students.Add(name, studentGrades);
                }
            }
            foreach (var item in students.Where(x => x.Value.Average() >= 4.50).OrderByDescending(x => x.Value.Average()))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");

            }


        }
    }
}
