using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Menu
    {
        public List<Salad> salads = new List<Salad>();
        public List<Pizza> pizzas = new List<Pizza>();



        public Menu()
        {
        }

        

        public void PrintSaladList()
        {
            //if the list is empty -> return
            if (this.salads.Count == 0)
            {
                Console.WriteLine("There are no menus yet.");
                return;
            }

            for (int i = 0; i < this.salads.Count; i++)
            {
                Console.WriteLine("---------------------------");
               
            }
        }

       
    }

   
}
