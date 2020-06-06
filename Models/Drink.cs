using System;


namespace iron_ninja.Models
{
    class Drink : IConsumable
    {
        public string Name {get; set;}
        public int Calories {get; set;}
        public bool IsSpicy {get; set;}
        public bool IsSweet {get; set;}
        public string GetInfo ()
        {
            return $"{Name} (Drink). Calories: {Calories}. Spicy?: {IsSpicy}. Sweet?: {IsSweet}.";
        }


        public Drink (string Name, int Calories, bool IsSpicy, bool IsSweet)
        {
            this.Name = Name;
            this.Calories = Calories;
            this.IsSpicy = false;
            this.IsSweet = true;
        }
    }

    
}