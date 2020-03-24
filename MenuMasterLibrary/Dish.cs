using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Dish
    {
        public string name { get; set; }

        public string description { get; set; }

        public double price { get; set; }

        public Dish(string name, double price, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;
        }

        public Dish()
        {
        }
    }
}
