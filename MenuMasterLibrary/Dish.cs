using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Dish
    {
        private string name;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {

                name = value;
            }

        }

        protected string description;

       
        public virtual string Description
        {
            get { return description; }
        }

        private double price;

       
        public double Price
        {
            get { return price; }
        }

        public Dish(string name, string description, double price)
        {
            this.Name = name;
            this.description = description;
            this.price = price;
        }
    }
}
