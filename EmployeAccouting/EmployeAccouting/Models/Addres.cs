using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeAccouting.Models
{
    public class Addres
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Home { get; set; }
        public string Apartment { get; set; }
        public string Value => $"{Country}, {City}, {Street}, {Home}, {Apartment}";
        public Addres(string country, string city, string street, string home, string apartment)
        {
            Country = country;
            City = city;
            Street = street;
            Home = home;
            Apartment = apartment;
        }
    }
}
