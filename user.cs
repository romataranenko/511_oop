using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _511_oop
{
    internal class Phone
    {
        string brand;
        string model;
        int price;

        public string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                brand = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}