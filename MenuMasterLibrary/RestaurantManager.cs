using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class RestaurantManager
    {
        /// <summary>
        /// First name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Creates a new restaurant manager.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        public RestaurantManager(string firstName, string lastName, string phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phone;
            Email = email;
        }
    }
}