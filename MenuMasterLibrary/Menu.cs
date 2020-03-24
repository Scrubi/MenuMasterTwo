using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Menu
    {
        List<Dish> dishes = new List<Dish>();

        public Menu()
        {
        }

        public void ShowList()
        {
            
                if (this.dishes.Count == 0)
                {
                    Console.WriteLine("Menu is empty.");
                    return;
                }

                for (int i = 0; i < this.dishes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{this.dishes[i].name}  {this.dishes[i].price}€  {this.dishes[i].description}");
                }
            


        }
    }

   
}
