using System;
using MenuMasterLibrary;

namespace MenuMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Restaurant restaurant = new Restaurant("Öl", "Aleksanterinkatu 19",
                new RestaurantManager("Jani", "Soronen", "041 999 333", "jani@restaurantol.com"));

            restaurant.AddMenuTestData();

            RestaurantUI ui = new RestaurantUI(restaurant);
            ui.ShowMenu();
        }
    }
}
