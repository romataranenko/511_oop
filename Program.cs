using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _511_oop
{
    public class Student
    {
        public string name;
        public string surname;
        public int age;
        public int degree;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "Tom";
            student.surname = "Doe";
            student.age = 25;
            student.degree = 25000;
            Console.WriteLine(student.name);
            Console.WriteLine(student.surname);
            Console.WriteLine(student.age);
            Console.WriteLine(student.degree);
            Console.WriteLine();
            Student student1 = new Student();
            student1.name = "Tim";
            student1.surname = "Doe";
            student1.age = 26;
            student1.degree = 2000;
            Console.WriteLine(student1.name);
            Console.WriteLine(student1.surname);
            Console.WriteLine(student1.age);
            Console.WriteLine(student1.degree);
            Console.WriteLine();
            Student student2 = new Student();
            student2.name = "Alecsander";
            student2.surname = "Doe";
            student2.age = 25;
            student2.degree = 25000;
            Console.WriteLine(student2.name);
            Console.WriteLine(student2.surname);
            Console.WriteLine(student2.age);
            Console.WriteLine(student2.degree);
            Console.WriteLine();
            Student student3 = new Student();
            student3.name = "jek";
            student3.surname = "Doe";
            student3.age = 26;
            student3.degree = 2000;
            Console.WriteLine(student3.name);
            Console.WriteLine(student3.surname);
            Console.WriteLine(student3.age);
            Console.WriteLine(student3.degree);
            Console.WriteLine();
        }
    }
}
