using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Buffet
    {
        public List<Food> Menu;
         
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Pizza", 1000, false, false),
                new Food("Apple Pie", 1500, false, true),
                new Food("Bufflao Wings", 850, true, false),
                new Food("Spaghetti", 900, false, true),
                new Food("Caesar Salad", 700, false, false),
                new Food("Orange", 250, false, true),
                new Food("Coffee", 75, false, false),
            };
        }

        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }

}