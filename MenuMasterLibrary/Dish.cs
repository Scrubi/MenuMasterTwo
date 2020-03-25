﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Dish
    {
        public string name;
        public double price;
        public string description;

       

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
        
        public static Dish CreateDish()
        {
            Console.WriteLine("Name of dish to be added:");
            string name = Console.ReadLine();
            Console.WriteLine("Price of dish to be added:");
            double price = int.Parse(Console.ReadLine());
            Console.WriteLine("Description of dish to be added:");
            string description = Console.ReadLine();

            Dish dish = new Dish(name, price, description);
            return dish;
          
        }

      

        public void AddNewDishToList()
        {
            Dish toAdd = Dish.CreateDish();
            this.dishes.Add(toAdd);
        }

    }
    
}
