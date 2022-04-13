using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                List<double> currentGrade = new List<double>();
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(studentName))
                {
                    currentGrade.Add(grade);
                    students.Add(studentName, currentGrade);
                }
                else
                {
                    students[studentName].Add(grade);
                }
            }
            Dictionary<string, double> goodStudents = new Dictionary<string, double>();
            foreach (var item in students)
            {
                if (item.Value.Average() >= 4.50)
                {
                    goodStudents.Add(item.Key, item.Value.Average());
                }
            }
            foreach (var item in goodStudents)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }
}
