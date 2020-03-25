using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Menu
    {
        List<Entree> entrees = new List<Entree>();
        List<MainCourse> mainCourses = new List<MainCourse>();
        List<Dessert> desserts = new List<Dessert>();
        List<Dish> dishes = new List<Dish>();

        public Menu()
        {
        }

        //Dish add (Uncategorized) start

        public Dish CreateDish()
        {
            Console.WriteLine("Name of dish to be added:");
            string name = Console.ReadLine();
            Console.WriteLine("Price for this dish:");
            double price = int.Parse(Console.ReadLine());
            Console.WriteLine("Description of this dish:");
            string description = Console.ReadLine();

            Dish dish = new Dish(name, price, description);
            return dish;

        }

        public void AddNewDishToList()
        {
            Dish dish = CreateDish();
            this.dishes.Add(dish);
        }

        //Dish add (Uncategorized) endpoint

        //Show list Dish (Uncategorized) start
        public void ShowDishesList()
        {

            if (this.dishes.Count == 0)
            {
                Console.WriteLine("Uncategorized Menu is empty.");
                return;
            }

            for (int i = 0; i < this.dishes.Count; i++)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Uncategorized Dishes");
                Console.WriteLine("--------------------");
                Console.WriteLine($"{i + 1}.{this.dishes[i].name}  {this.dishes[i].price}€  \n\nDescription: {this.dishes[i].description}");
            }

        }

        //Show list Dish (Uncategorized) endpoint

        //Dish add (Dessert) start
        public Dessert CreateDessert()
        {
            Console.WriteLine("Name of dessert to be added:");
            string name = Console.ReadLine();
            Console.WriteLine("Price for this dessert:");
            double price = int.Parse(Console.ReadLine());
            Console.WriteLine("Description of this dessert:");
            string description = Console.ReadLine();

            Dessert dessert = new Dessert(name, price, description);
            return dessert;
        }

        public void AddNewDessertToList()
        {
            Dessert dessert = CreateDessert();
            this.desserts.Add(dessert);
        }

        //Dish add (Dessert) endpoint

        //Show list Dish (Dessert) start

        public void ShowDessertList()
        {

            if (this.dishes.Count == 0)
            {
                Console.WriteLine("Dessert Menu is empty.");
                return;
            }

            for (int i = 0; i < this.desserts.Count; i++)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("      Desserts");
                Console.WriteLine("--------------------");
                Console.WriteLine($"{i + 1}.{this.desserts[i].name}  {this.desserts[i].price}€  \n\nDescription: {this.desserts[i].description}");
            }

        }
        //Show list Dish (Dessert) endpoint

        //Dish add (Entree) start

        public Entree CreateEntree()
        {
            Console.WriteLine("Name of entree to be added:");
            string name = Console.ReadLine();
            Console.WriteLine("Price for this entree:");
            double price = int.Parse(Console.ReadLine());
            Console.WriteLine("Description of this entree:");
            string description = Console.ReadLine();

            Entree entree = new Entree(name, price, description);
            return entree;
        }

        public void AddNewEntreeToList()
        {
            Entree entree = CreateEntree();
            this.entrees.Add(entree);
        }

        //Dish add (Entree) endpoint

        //Show list Dish (Entree) start

        public void ShowEntreeList()
        {

            if (this.dishes.Count == 0)
            {
                Console.WriteLine("Entree Menu is empty.");
                return;
            }

            for (int i = 0; i < this.desserts.Count; i++)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("      Entrees");
                Console.WriteLine("--------------------");
                Console.WriteLine($"{i + 1}.{this.entrees[i].name}  {this.entrees[i].price}€  \n\nDescription: {this.entrees[i].description}");
            }

        }

        //Show list Dish (Dessert) endpoint

        //Dish add (Main Course) start

        public MainCourse CreateMainCourse()
        {
            Console.WriteLine("Name of main course to be added:");
            string name = Console.ReadLine();
            Console.WriteLine("Price for this main course:");
            double price = int.Parse(Console.ReadLine());
            Console.WriteLine("Description of this main course:");
            string description = Console.ReadLine();

            MainCourse mainCourse = new MainCourse(name, price, description);
            return mainCourse;
        }

        public void AddNewMainCourseToList()
        {
            MainCourse mainCourse = CreateMainCourse();
            this.mainCourses.Add(mainCourse);
        }

        //Dish add (Main Course) endpoint

        //Show list Dish (Main Course) start

        public void ShowMainCourseList()
        {

            if (this.mainCourses.Count == 0)
            {
                Console.WriteLine("Main Course Menu is empty.");
                return;
            }

            for (int i = 0; i < this.mainCourses.Count; i++)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("   Main Courses");
                Console.WriteLine("--------------------");
                Console.WriteLine($"{i + 1}.{this.mainCourses[i].name}  {this.mainCourses[i].price}€  \n\nDescription: {this.mainCourses[i].description}");
            }

        }

        //Show list Dish (Main Course) endpoint

    }


}
