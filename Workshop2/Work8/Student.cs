using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work8
{
    public class Student : IStudent
    {
        public string Name { get; set; }
        public int StudentNumber { get; set; }

        Dictionary<string, int> grades = new Dictionary<string, int>();
        public Dictionary<string, int> Grades => grades;

        public void AddGrade(string course, int grade)
        {
            if (grades.ContainsKey(course))
            {
                Console.WriteLine($"{course} notu zaten eklenmiş");
            }
            else
            {
                grades.Add(course, grade);
                Console.WriteLine(course +" için ders notu : " + grade +" olarak eklendi");
            }
        }

        public void PrintTranscript()
        {
            Console.WriteLine($"Transkript for {Name} (Student Number: {StudentNumber}):");
            foreach (var grade in grades)
            {
                Console.WriteLine(grade.Key +" " +grade.Value);
            }
        }
    }
}
