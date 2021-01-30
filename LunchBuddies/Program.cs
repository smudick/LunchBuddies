using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var buddy = new LunchBuddy("Sam", "M");
            var buddy2 = new LunchBuddy("Dana", "J");
            var buddy3 = new LunchBuddy("Kaitlyn", "T");
            var buddy4 = new LunchBuddy("Nathan", "G");
            var buddy5 = new LunchBuddy("Jameka", "Name");
            var buddy6 = new LunchBuddy("Dylan", "F");

            List<LunchBuddy> companions = new List<LunchBuddy>();

            companions.Add(buddy);
            companions.Add(buddy2);
            companions.Add(buddy3);
            companions.Add(buddy4);
            companions.Add(buddy5);
            companions.Add(buddy6);
            
            buddy.Eat();
            buddy.Eat("Pizza");
            buddy.Eat(companions);
            buddy.Eat("Pizza", companions);
            
        }
    }
}
