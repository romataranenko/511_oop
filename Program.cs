using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _511_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            phone.Brand = "Afon";
            phone.Model = "afon10";
            phone.Price = 40000;
            Console.WriteLine(phone.Brand);
            Console.WriteLine(phone.Model);
            Console.WriteLine(phone.Price);
        }
    }
}
