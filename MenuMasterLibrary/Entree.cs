using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Entree
    {
        public List<Entree> entrees = new List<Entree>();
        public string name;
        public string description;
        public double price;
        public Entree()
        {

        }

        public Entree(string name, double price, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;
        }       
    }
}
