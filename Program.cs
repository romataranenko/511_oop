using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _511_oop
{
    using System;

    public class Student
    {
        private string fullName;
        private DateTime dateOfBirth;
        private string contactPhone;
        private string city;
        private string country;
        private string university;
        private string universityCity;
        private string universityCountry;
        private string groupNumber;

        public void InputData()
        {
            Console.Write("Введите Ф. И. О.: ");
            fullName = Console.ReadLine();

            Console.Write("Введите дату рождения (дд.мм.гггг): ");
            dateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите контактный телефон: ");
            contactPhone = Console.ReadLine();

            Console.Write("Введите город: ");
            city = Console.ReadLine();

            Console.Write("Введите страну: ");
            country = Console.ReadLine();

            Console.Write("Введите название учебного заведения: ");
            university = Console.ReadLine();

            Console.Write("Введите город, где находится учебное заведение: ");
            universityCity = Console.ReadLine();

            Console.Write("Введите страну, где находится учебное заведение: ");
            universityCountry = Console.ReadLine();

            Console.Write("Введите номер группы: ");
            groupNumber = Console.ReadLine();
        }


        public void PrintData()
        {
            Console.WriteLine("Ф. И. О.: " + fullName);
            Console.WriteLine("Дата рождения: " + dateOfBirth.ToShortDateString());
            Console.WriteLine("Контактный телефон: " + contactPhone);
            Console.WriteLine("Город: " + city);
            Console.WriteLine("Страна: " + country);
            Console.WriteLine("Учебное заведение: " + university);
            Console.WriteLine("Город учебного заведения: " + universityCity);
            Console.WriteLine("Страна учебного заведения: " + universityCountry);
            Console.WriteLine("Номер группы: " + groupNumber);
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string ContactPhone
        {
            get { return contactPhone; }
            set { contactPhone = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string University
        {
            get { return university; }
            set { university = value; }
        }

        public string UniversityCity
        {
            get { return universityCity; }
            set { universityCity = value; }
        }

        public string UniversityCountry
        {
            get { return universityCountry; }
            set { universityCountry = value; }
        }

        public string GroupNumber
        {
            get { return groupNumber; }
            set { groupNumber = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.InputData();
            student.PrintData();
        }
    }
}
