using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    

        public class Dessert
        {
            public List<Dessert> desserts = new List<Dessert>();
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
            public static Dessert CreateDessert()
            {
                Console.WriteLine("Name of dish to be added:");
                string name = Console.ReadLine();
                Console.WriteLine("Price of dish to be added:");
                double price = int.Parse(Console.ReadLine());
                Console.WriteLine("Description of dish to be added:");
                string description = Console.ReadLine();

                Dessert dessert = new Dessert(name, price, description);
                return dessert;
            }

            public void AddNewDessertToList()
            {
                Dessert toAdd = Dessert.CreateDessert();
                this.desserts.Add(toAdd);
            }
        }

  



        //Adding List of Entrees
       
   
}

