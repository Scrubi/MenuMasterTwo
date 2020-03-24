using System;
using MenuMasterLibrary;

namespace MenuMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            

            RestaurantUI mainMenu = new RestaurantUI();
            mainMenu.InitializeMainMenu();
        }
    }
}
