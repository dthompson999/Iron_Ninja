using System;
using iron_ninja.Models;

namespace iron_ninja
{
    class SpiceHound : Ninja
    {
        public string Name;
        public SpiceHound(string Name)
        {
            this.Name = Name;

        }

        public override bool IsFull
        {
            get
            {
                if (calorieIntake >= 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override void Consume(IConsumable item)
        {
            if (IsFull == false)
            {
                calorieIntake += item.Calories;
                if (item.IsSpicy == true)
                {
                    calorieIntake -= 5;
                }
                ConsumptionHistory.Add(item);
                Console.WriteLine(item.GetInfo());
            }
            else if (IsFull == true)
            {
                ConsoleRed($"{Name} is filled to the gills!!! SHUT THE BUFFET DOWN!!!");
                ConsoleYellow($"***** {Name}'s Food History: *****");
                foreach (IConsumable history in ConsumptionHistory)
                {
                    Console.WriteLine(history.Name);
                }
                ConsoleRed($"Total Calories: {calorieIntake}");
            }
        }
        static void ConsoleYellow(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        static void ConsoleRed(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}