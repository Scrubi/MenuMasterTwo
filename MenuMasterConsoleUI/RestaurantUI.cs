using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class RestaurantUI
    {

        private Restaurant restaurant;

        public RestaurantUI(Restaurant restaurant)
        {
            this.restaurant = restaurant;
        }

        private void AddNewDish()
        {
            Console.WriteLine("Select menu for this dish to be added in:");
            PrintMenuName();
            int menuNumber = ReadInt("Your selestion:", 1, restaurant.MenuCount);
            Menu menu = restaurant.Menus[menuNumber - 1];

            Console.WriteLine("Choose category for this dish:");
            PrintStrings(menu.GetNamesOfCategories());
            int categoryInt = ReadInt("Category chosen:",
                1, Enum.GetNames(typeof(Menu.Category)).Length) - 1;
            Menu.Category category = (Menu.Category)categoryInt;

            Console.WriteLine("Name of this dish:");
            string name = Console.ReadLine();

            Console.WriteLine("Short description of this dish:");
            string description = Console.ReadLine();

            double price = ReadDouble("Price of this dish:");

            
            menu.AddDish(category, name, description, price);
            
        }

        private void PrintStrings(List<string> list)
        {
            int i = 1;
            foreach (var str in list)
            {
                Console.WriteLine($"{i}. {str}");
                i++;
            }
        }

        private void RemoveDish()
        {
            Console.WriteLine("Select menu that you wish to delete a dish from:");
            PrintMenuName();
            int menuNumber = ReadInt("Your Selection:", 1, restaurant.MenuCount);
            Menu menu = restaurant.Menus[menuNumber - 1];

            if (menu.DishCount == 0)
            {
                Console.WriteLine("This menu has no dishes to be removed!");
                return;
            }

            Console.WriteLine("Select category that you wish to delete a dish from:");
            PrintStrings(menu.GetNamesOfCategories());
            int categoryInt = ReadInt("Your Selection:",
                1, Enum.GetNames(typeof(Menu.Category)).Length);
            Menu.Category category = (Menu.Category)categoryInt;
            MenuCategories menuCategory = menu.Categories[categoryInt - 1]; 

            if (menuCategory.Dishes.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Removing dish failed because category is empty!");
                Console.ResetColor();
                return;
            }

            PrintStrings(menu.GetNamesOfDishes(category));
            int dishNumber = ReadInt("Select the ID number of dish to be removed:", 1, menu.DishCount);
            menu.RemoveDish(category, dishNumber - 1);
        }

        public void ShowMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private bool MainMenu()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    ----------------------------");
            Console.WriteLine("         Restaurant Manager       ");
            Console.WriteLine("    ----------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("          1. Show Menu");
            Console.WriteLine("          2. Add new Menu");
            Console.WriteLine("          3. Remove Menu");
            Console.WriteLine("          4. Add Dish");
            Console.WriteLine("          5. Remove Dish");
            Console.WriteLine("          0. Exit");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("         Choose action:");
            Console.ResetColor();

            string valinta = Console.ReadLine();
            Console.Clear();
            switch (valinta)
            {
                case "1":
                    PrintMenu();
                    break;
                case "2":
                    AddMenu();
                    break;
                case "3":
                    RemoveMenu();
                    break;
                case "4":
                    AddNewDish();
                    break;
                case "5":
                    RemoveDish();
                    break;

                case "0":
                    
                    return false;
                default:
                    
                    return true;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            return true;
        }

        public void PrintMenuName()
        {
            int i = 1;
            foreach (var menu in restaurant.Menus)
            {
                Console.WriteLine($"{i}. {menu.Description}");
                i++;
            }
        }

        private static int ReadInt(string message, int min, int max)
        {
            int value = 0;
            bool valueOK = false;

            while (!valueOK)
            {
                Console.WriteLine(message);
                valueOK = int.TryParse(Console.ReadLine(), out value);
                if (!valueOK || value < min || value > max)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid number!");
                    Console.ResetColor();
                    valueOK = false;
                }
            }

            return value;
        }

        private static double ReadDouble(string message)
        {
            double value = 0;
            bool valueOK = false;

            while (valueOK == false)
            {
                Console.WriteLine(message);
                valueOK = double.TryParse(Console.ReadLine(), out value);
                if (valueOK == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid number!");
                    Console.ResetColor();
                }
            }

            return value;
        }

        public Menu ChooseMenu()
        {
            if (restaurant.MenuCount == 0)
            {
                return null;
            }
            else
            {
                Console.WriteLine("Select menu you wish to display:");
                PrintMenuName();
                int number = ReadInt("Your selection:", 1, restaurant.MenuCount);
                return restaurant.Menus[number - 1];
            }
        }

        public Menu AddMenu()
        {
            Console.WriteLine("Write menu description:");
            string description = Console.ReadLine();
            Menu menu = new Menu(description);
            restaurant.Menus.Add(menu);
            return menu;
        }

        private void RemoveMenu()
        {
            Console.WriteLine("Select menu that you wish to delete:");
            PrintMenuName();
            int menuNumber = ReadInt("Your Selection:", 1, restaurant.MenuCount);
            Menu menu = restaurant.Menus[menuNumber - 1];

            restaurant.Menus.Remove(menu);
        }

        public void PrintMenu()
        {
            Menu menu = ChooseMenu();

            Console.WriteLine("Select order for menu items:");
            Console.WriteLine("1. Default");
            Console.WriteLine("2. Alphabetical");
            Console.WriteLine("3. Price");
            int sort = ReadInt("Your selection:", 1, 3);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"    Restaurant {restaurant.Name}");
            Console.WriteLine($"    {menu.Description}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ResetColor();

            foreach (var category in menu.Categories)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"---------- {category.Name} ----------");
                Console.ResetColor();
                List<Dish> dishes = category.GetDishes((MenuCategories.SortingMode)sort);
                foreach (Dish dish in dishes)
                {
                    PrintDish(dish);
                }
            }
            Console.WriteLine();
        }

        private void PrintDish(Dish dish)
        {
            Console.WriteLine(dish.Name);
            Console.WriteLine($"\t{dish.Description}");
            Console.WriteLine($"\t{dish.Price} euros");
        }
    }
}