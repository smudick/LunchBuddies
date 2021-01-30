using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        List<string> Restaurants { get; set; } = new List<string>() { "Nicolettos", "Burger Up", "Rolf and Daughters" };
        public string Name { get; set; }

        public Restaurant()
        {
            var random = new Random();
            int index = random.Next(Restaurants.Count);
            Name = Restaurants[index];
        }
    }
}
