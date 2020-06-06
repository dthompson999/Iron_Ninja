using System;
using iron_ninja.Models;

namespace iron_ninja
{
    class SweetTooth : Ninja
    {
        public string Name;
        public SweetTooth(string Name)
        {
            this.Name = Name;

        }

        public override bool IsFull
        {
            get
            {
                if (calorieIntake >= 1500)
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
                if (item.IsSweet == true)
                {
                    calorieIntake += 10;
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