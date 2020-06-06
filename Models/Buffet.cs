using System;
using System.Collections.Generic;


namespace iron_ninja.Models
{
    class Buffet
    {
        public List<IConsumable> Menu;

        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Kung Pao Chicken",     350, true, false),
                new Food("Beef & Broccoli",      170, false, false),
                new Food("Char Siu Pork Belly",  400, false, true),
                new Food("Black Pepper Chicken", 200, true, false),
                new Food("Soy Glazed Chicken",   150, false, false),
                new Food("Miso Tofu Soup",        70, false, false),
                new Food("Bi Bim Bap Bowl",      750, true, false),
                new Drink("Coke",                140, false, true),
                new Drink("Iced Tea",             90, false, true),
                new Drink("Water",                 0, false, false),
                new Drink("Coffee",                5, false, false)
            
            };
        }
        public IConsumable Serve()
        {
            Random RandomConsumable = new Random();
            return Menu[RandomConsumable.Next(Menu.Count)];
        }
    }
}