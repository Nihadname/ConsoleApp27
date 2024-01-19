using ConsoleApp27.Domain.Models;
using ConsoleApp27.Services.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp27.Services.Services
{
    public class StudentMethods: SearchMethod
    {
        public Student[] students()
        {

            Student student = new("Nihad ", "Ibadzade");
            Student student1 = new("Teymur", "filankesov");
            Student student2 = new("Kamil", "Memmedov");
            Student student3 = new("Amin", "ehmmedli");
            Student student4 = new("Kazim", "filankesov");
            Student student5 = new("Ehmed", "Kazimov");
            Student[] studens = { student, student1, student2, student3, student4, student5 };
            return studens;
        }
        public void Search(string name, string surName)
        {
            foreach (Student student in students())
            {
                if (student.Name == name)
                {
                    Console.WriteLine($"{student.Name} {student.SurName} {student.Id}");
                }

            }
        }

        public int GettingTheSameNames(string name)
        {
            int count = 0;
            foreach (Student student in students())
            {
                if (student.Name == name)
                {
                    count++;
                }

            }
            return count;
        }
    }
}
