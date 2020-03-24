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

        public List<Dish> dishes = new List<Dish>();

        public Dish(string name, double price, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;
        }

        public Dish()
        {
        }

        public Dish CreateDish()
        {
            

                Console.WriteLine("Anna annoksen nimi:");
                string name = Console.ReadLine();
                Console.WriteLine("Anna annoksen hinta:");
                double price = int.Parse(Console.ReadLine());
                Console.WriteLine("Anna annoksen kuvaus:");
                string description = Console.ReadLine();

                Dish dish = new Dish(name, price, description);
                return dish;
        }

        public void AddNewDishToList()
        {
            Dish toAdd = CreateDish();
            this.dishes.Add(toAdd);
            
            
        }

    }
    
}
