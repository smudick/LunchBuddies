using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }


        public Restaurant Eat()
        {
            var rest = new Restaurant();
            Console.WriteLine($"Buddy is eating at {rest.Name}");
            return rest;
        }
        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} is eating {food} at the office");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            var rest = new Restaurant();
            string buddies = "";
            for (int i = 0; i < companions.Count; i++)
            {
                if (i == companions.Count - 1)
                {
                    buddies += $"and {companions[i].FirstName}";
                }
                else
                {
                    buddies += $" {companions[i].FirstName}, ";
                }
            }
            Console.WriteLine($"{FirstName} {LastName} is at {rest.Name} with {buddies}");
        }
        public void Eat(string food, List<LunchBuddy> companions)
        {
            var rest = new Restaurant();
            string buddies = "";
            for (int i = 0; i < companions.Count; i++)
            {
                if (i == companions.Count - 1)
                {
                    buddies += $"and {companions[i].FirstName}";
                }
                else
                {
                    buddies += $" {companions[i].FirstName}, ";
                }
            }
            Console.WriteLine($"{FirstName} {LastName} is eating {food} at {rest.Name} with {buddies}");
        }
    }
}
