﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                Student student = new Student(); 
                   student.FirstName = firstName;
                   student.LastName = lastName;
                   student.Age = age;
                   student.HomeTown = homeTown;
                students.Add(student);
                line = Console.ReadLine();
            }
            string filterCity = Console.ReadLine();
            List<Student> filteredStudents = students.Where(s => s.HomeTown == filterCity).ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }

        }
    }
}
