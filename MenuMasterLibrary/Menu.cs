using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Menu
    {
        private string description;
        private List<MenuCategory> categories = new List<MenuCategory>();

        public string Description
        {
            get { return description; }
        }

 
        public List<MenuCategory> Categories
        {
            get { return categories; }
        }

      
        public int DishCount
        {
            get
            {
                int count = 0;
                foreach (var category in Categories)
                {
                    count += category.Dishes.Count;
                }
                return count;
            }
        }

        public enum Category
        {
            Entrees = 0,
            MainCourse,
            Dessert,
            Uncategorized
        }

        public Menu(string description)
        {
            this.description = description;
            categories.Add(new MenuCategory("Entrees")); 
            categories.Add(new MenuCategory("Maincourses")); 
            categories.Add(new MenuCategory("Dessert"));
            categories.Add(new MenuCategory("Uncategorized"));
        }

        public List<string> GetNamesOfDishes(Category category)
        {
            MenuCategory dishCategory = Categories[(int)category];
            List<string> list = new List<string>();
            foreach (var dish in dishCategory.Dishes)
            {
                list.Add(dish.Name);
            }
            return list;
        }

        public void AddDish(Category category, string name, string descr, double price)
        {
            AddDish(category, new Dish(name, descr, price));
        }

        public void AddDish(Category category, Dish dish)
        {
            Categories[(int)category].AddDish(dish);
        }

     
        public bool RemoveDish(Category category, int index)
        {
            if (index >= 0 && index < Categories.Count)
            {
                return Categories[(int)category].RemoveDish(index);
            }
            return false;
        }

        public List<string> GetNamesOfCategories()
        {
            List<string> list = new List<string>();
            foreach (MenuCategory category in Categories)
            {
                list.Add(category.Name);
            }
            return list;
        }
    }
}
