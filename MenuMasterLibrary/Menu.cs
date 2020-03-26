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

        //Test data for Menu start
        public void FillMenusWithTestData()
        {
            this.dishes.Add(new Dish("Sushi", 6, "Chef's special sushi with mild wasabi paste"));
            this.dishes.Add(new Dish("Tonkotsu Ramen", 8, "Our Spicy Tonkotsu Ramen strikes a perfect balance between heat and flavor"));
            this.entrees.Add(new Entree("Nachos", 2, "Bowl of delicious nachos with cheese dip"));
            this.entrees.Add(new Entree("Cheese sticks", 3, "Small basket of 8 cheese sticks that burst with flavor"));
            this.mainCourses.Add(new MainCourse("Chef's Juicy BBQ Burger", 12.5, "This award winning burger will blow your mind and your taste buds will be throughly satisfied"));
            this.mainCourses.Add(new MainCourse("Lean Steak", 13.95, "Steak drizzled in our special spiced oil, topped with spring onions and caramellized lager sauce"));
            this.desserts.Add(new Dessert("Vanilla Ice Cream", 6.5, "Classic homemade vanilla ice cream with topping of your choice (strawberries, blueberries, chocolate melt)"));
            this.desserts.Add(new Dessert("Powder sugar coated Brownie", 8.5, "This Brownie literally melts in your mouth giving you instant sweetness and satisfaction"));
            
        }

        //Test data for Menu endpoint

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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------------");
            Console.WriteLine("Uncategorized Dishes");
            Console.WriteLine("--------------------");
            Console.ResetColor();

            if (this.dishes.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine("--------------------");
                //Console.WriteLine("Uncategorized Dishes");
                //Console.WriteLine("--------------------");
                Console.WriteLine("\nUncategorized Menu is empty.\n");
                Console.ResetColor();
                return;
            }

            for (int i = 0; i < this.dishes.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{i + 1}.{this.dishes[i].name}  {this.dishes[i].price} euros  \n\n{this.dishes[i].description}\n\n");
                Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------");
            Console.WriteLine("      Desserts");
            Console.WriteLine("--------------------");
            Console.ResetColor();

            if (this.desserts.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                //Console.WriteLine("--------------------");
                //Console.WriteLine("      Desserts");
                //Console.WriteLine("--------------------");
                Console.WriteLine("\nDessert Menu is empty.\n");
                Console.ResetColor();
                return;
            }

            for (int i = 0; i < this.desserts.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{i + 1}.{this.desserts[i].name}  {this.desserts[i].price} euros  \n\n{this.desserts[i].description}\n\n");
                Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------");
            Console.WriteLine("      Entrees");
            Console.WriteLine("--------------------");
            Console.ResetColor();

            if (this.entrees.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine("--------------------");
                //Console.WriteLine("      Entrees");
                //Console.WriteLine("--------------------");
                Console.WriteLine("\nEntree Menu is empty.\n");
                Console.ResetColor();
                return;
            }

            for (int i = 0; i < this.desserts.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{i + 1}.{this.entrees[i].name}  {this.entrees[i].price} euros  \n\n{this.entrees[i].description}\n\n");
                Console.ResetColor();
                
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------");
            Console.WriteLine("   Main Courses");
            Console.WriteLine("--------------------");
            Console.ResetColor();

            if (this.mainCourses.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                //Console.WriteLine("--------------------");
                //Console.WriteLine("   Main Courses");
                //Console.WriteLine("--------------------");
                Console.WriteLine("\nMain Course Menu is empty.\n");
                Console.ResetColor();
                return;
            }

            for (int i = 0; i < this.mainCourses.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{i + 1}.{this.mainCourses[i].name}  {this.mainCourses[i].price}euros  \n\n{this.mainCourses[i].description}\n\n");
                Console.ResetColor();
            }

        }

        //Show list Dish (Main Course) endpoint

    }


}
