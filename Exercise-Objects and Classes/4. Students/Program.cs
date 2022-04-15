using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> listOFStudents = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {

                string[] studentsInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string firstName = studentsInfo[0];
                string lastName = studentsInfo[1];
                double grade = double.Parse(studentsInfo[2]);
                Student newStudent = new Student(firstName, lastName, grade);
                listOFStudents.Add(newStudent);
            }
            listOFStudents = listOFStudents.OrderByDescending(x => x.Grade).ToList();
            Console.WriteLine(String.Join(Environment.NewLine, listOFStudents));
        }
    }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
}
