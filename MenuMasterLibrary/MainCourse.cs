﻿using System;
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
     
    }
}
