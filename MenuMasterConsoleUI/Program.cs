using System;
using MenuMasterLibrary;

namespace MenuMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu mn = new Menu();
            mn.FillMenusWithTestData();
            RestaurantUI mainMenu = new RestaurantUI(mn);
            mainMenu.InitializeMainMenu();
        }
    }
}
