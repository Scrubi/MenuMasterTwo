using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    class RestaurantUI
    {

        public Dish dish;

        public RestaurantUI()
        {
        }

       

        public RestaurantUI(Dish dish)
        {
            this.dish = dish;
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
                    dish.AddNewDishToList();
                    Console.ReadKey();
                    break;

                case 0:
                    return false;
                default:
                    Console.Clear();
                    return true;
            }
            Console.WriteLine("\nPress a key to continue...");
            Console.ReadKey();
            return true;

        }

    }
}

