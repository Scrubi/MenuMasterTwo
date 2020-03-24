using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Categories
    {
        public List<Salad> salads = new List<Salad>();
        public List<Pizza> pizzas = new List<Pizza>();
    }

    public class Salad
    {
        public int categoryid { get; set; }
        public string categoryname { get; set; }
      

        public Salad(Dish dish)
        {

        }

        public Salad(int categoryid, string categoryname)
        {
            this.categoryid = 1;
            this.categoryname = "Salads";
        }

      
    }

    public class Pizza
    {
        public int categoryid { get; set; }
        public string categoryname { get; set; }

        public Pizza()
        {

        }

        public Pizza(int categoryid, string categoryname)
        {
            this.categoryid = 2;
            this.categoryname = "Pizzas";
        }
    }
}
