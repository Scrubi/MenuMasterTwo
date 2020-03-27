using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Restaurant
    {
        private RestaurantManager manager;
        private string name;
        private string address;
        private List<Menu> menuList = new List<Menu>();

     
        public string Name
        {
            get { return name; }
        }

      
        public string Address
        {
            get { return address; }
        }

      
        public RestaurantManager Manager
        {
            get
            {
                return manager;
            }
        }

      
        public List<Menu> Menus
        {
            get
            {
                return menuList;
            }
        }

        public int MenuCount
        {
            get
            {
                return menuList.Count;
            }
        }

        public Restaurant(string name, string address, RestaurantManager manager)
        {
            this.name = name;
            this.address = address;
            this.manager = manager;
        }

        public void AddMenu(Menu menu)
        {
            Menus.Add(menu);
        }

        public void AddMenuTestData()
        {
            Menu menu1 = new Menu("Lunch menu");
            AddMenu(menu1);
            menu1.AddDish(Menu.Category.Entrees, "Nachos", "Basket of crisp and delicious nachos", 4.60);
            menu1.AddDish(Menu.Category.MainCourse, "Chef's Special BBQ Burger", "This award winning burger will show you what the definition of an excellent burger really is!", 14.65);
            menu1.AddDish(Menu.Category.MainCourse, "Lean Steak", "Thin steak drizzled in garlic oil, topped with spring onions", 12.95);
            menu1.AddDish(Menu.Category.MainCourse, "Chicken Breast", "Tender, moist and delicious chicken breast, slightly spicy with side dish of your selection (rice, fries, salad)", 10.95);
            menu1.AddDish(Menu.Category.Dessert, "Homemade Ice Cream", "Our very own homemade ice cream with three flavours to choose from (chocolate, strawberry, blueberry)", 6.45);
            

            Menu menu2 = new Menu("Chef's Daily Surprise -menu");
            AddMenu(menu2);
            menu2.AddDish(Menu.Category.MainCourse, "Tonkotsu Ramen", "Chef's Spicy Tonkotsu Ramen strikes a perfect balance between heat and umami by combining homemade spicy sesame oil and traditional Tonkotsu Ramen together.", 12.95);
        }









    }
}