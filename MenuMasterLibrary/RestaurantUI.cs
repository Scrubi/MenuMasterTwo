using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class RestaurantUI
    {

        public Dish dish;
        public Entree entree;
        public MainCourse mainCourse;
        public Dessert dessert;
     
        public RestaurantUI()
        {
        }

        
        public void InitializeMainMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = ShowMainMenu();
            }
        }

        private bool ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("--------------");
            Console.WriteLine("Restaurant Öl");
            Console.WriteLine("--------------");
            Console.WriteLine("1. Add Menu. ");
            Console.WriteLine("2. Show Menu. ");
            Console.WriteLine("3. Add new dish. ");


            Console.WriteLine("0. Exit ");
            int selected = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (selected)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:
                    Console.WriteLine("\n Select Category for this dish:");
                    Console.WriteLine("1. Entrees");
                    Console.WriteLine("2. Main Course");
                    Console.WriteLine("3. Dessert");
                    Console.WriteLine("4. No Category");
                    int select = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (select)
                    {
                        case 1:
                            Entree entree = new Entree();
                            entree.AddNewEntreeToList();
                            Console.ReadKey();
                            break;

                        case 2:
                            MainCourse mainCourse = new MainCourse();
                            mainCourse.AddNewMainCourseToList();
                            Console.ReadKey();
                            break;
                        case 3:
                            Dessert dessert = new Dessert();
                            dessert.AddNewDessertToList();
                            Console.ReadKey();
                            break;
                        case 4:
                            Dish dish = new Dish();
                            dish.AddNewDishToList();
                            Console.ReadKey();
                            break;
                    }
                    break;

                case 0:
                    return false;
            }
                    
            Console.WriteLine("\nPress a key to continue...");
            Console.ReadKey();
            return true;

        }
    }
}

