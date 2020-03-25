using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class RestaurantUI
    {

       
        public Menu menu;
        public RestaurantUI()
        {
        }

        public RestaurantUI(Menu menu) 
        {
            this.menu = menu;
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
            Console.WriteLine("1. Add Menu. //under construction ");
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
                    
                    menu.ShowEntreeList();
                    menu.ShowMainCourseList();
                    menu.ShowDessertList();
                    menu.ShowDishesList();
                    Console.ReadKey();
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
                            //Entree entree = new Entree();
                            menu.AddNewEntreeToList();
                            Console.ReadKey();
                            break;

                        case 2:
                            //MainCourse mainCourse = new MainCourse();
                            menu.AddNewMainCourseToList();
                            Console.ReadKey();
                            break;
                        case 3:
                            //Dessert dessert = new Dessert();
                            menu.AddNewDessertToList();
                            Console.ReadKey();
                            break;
                        case 4:
                            //Dish dish = new Dish();
                            menu.AddNewDishToList();
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

