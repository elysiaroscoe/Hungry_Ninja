using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            Ninja ninja = new Ninja();

            while (!ninja.IsFull)
            {
                ninja.Eat(buffet.Serve());
            }
            System.Console.WriteLine("The Ninja has eaten until full!");
        }
    }
}
