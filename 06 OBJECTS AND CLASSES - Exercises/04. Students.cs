using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for(int i=0; i<number; i++)
            {
                List<string> studentInfo = Console.ReadLine().Split(' ').ToList();

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);

                Student createdStudent = new Student(firstName, lastName, grade);

                students.Add(createdStudent);
            }

            List<Student> sortedByGrade = students.OrderBy(order => order.Grade).ToList();

            for(int j = (sortedByGrade.Count-1); j>=0; j--)
            {
                Console.WriteLine($"{sortedByGrade[j].FirstName} {sortedByGrade[j].LastName}: {sortedByGrade[j].Grade:F2}");
            }
        }

        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public Student(string firstName, string lastName, double grade)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Grade = grade;
            }
        }
    }
}
