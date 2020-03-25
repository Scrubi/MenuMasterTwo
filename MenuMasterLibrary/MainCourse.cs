using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class MainCourse
    {
        public List<MainCourse> mainCourses = new List<MainCourse>();
        public string name;
        public string description;
        public double price;

        public MainCourse()
        {

        }

        public MainCourse(string name, double price, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;
        }
        public static MainCourse CreateMainCourse()
        {
            Console.WriteLine("Name of dish to be added:");
            string name = Console.ReadLine();
            Console.WriteLine("Price of dish to be added:");
            double price = int.Parse(Console.ReadLine());
            Console.WriteLine("Description of dish to be added:");
            string description = Console.ReadLine();

            MainCourse maincourse = new MainCourse(name, price, description);
            return maincourse;
        }

        public void AddNewMainCourseToList()
        {
            MainCourse toAdd = MainCourse.CreateMainCourse();
            this.mainCourses.Add(toAdd);
        }
    }
}
