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

        public static Entree CreateEntree()
        {
            Console.WriteLine("Name of dish to be added:");
            string name = Console.ReadLine();
            Console.WriteLine("Price of dish to be added:");
            double price = int.Parse(Console.ReadLine());
            Console.WriteLine("Description of dish to be added:");
            string description = Console.ReadLine();

            Entree entree = new Entree(name, price, description);
            return entree;
        }

        public void AddNewEntreeToList()
        {
            Entree toAdd = Entree.CreateEntree();
            this.entrees.Add(toAdd);
        }
    }
}
