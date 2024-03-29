﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < loops; i++)
            {
                string[] input = Console.ReadLine().Split();
                Student student = new Student(input[0],input[1],double.Parse(input[2]));

                students.Add(student);  
            }
           students = students.OrderByDescending(student => student.Grade).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
