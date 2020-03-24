using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class RestaurantUI
    {
        private Menu mn;

        public RestaurantUI(Menu mn)
        {
            this.mn = mn;
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
            Console.WriteLine("Restaurant Öl");
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
                    mn.PrintSaladList();
                    break;
                case 3:

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

