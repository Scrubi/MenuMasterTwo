using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    

        public class Dessert
        {
            
            public string name;
            public string description;
            public double price;

            public Dessert()
            {

            }

            public Dessert(string name, double price, string description)
            {
                this.name = name;
                this.price = price;
                this.description = description;
            }
            
        }

}

