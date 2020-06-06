using System;
using System.Collections.Generic;

namespace iron_ninja.Models
{
    abstract class Ninja
    {
        protected int calorieIntake;
        public List<IConsumable> ConsumptionHistory;

        public Ninja()
        {
            this.calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }

        public abstract bool IsFull {get;}
         //  Commented out when property changed to abstract, saving code if needed later for child class of ninja
        // {
        //     get
        //     {
        //         if (calorieIntake >= 1200)
        //         {
        //             return true;
        //         }
        //         else
        //         {
        //             return false;
        //         }
        //     }
        // }


        public abstract void Consume(IConsumable item);
        //  Commented out when method changed to abstract, saving code if needed later for child class of ninja
        // {
        //     if (IsFull == false)
        //     {
        //         calorieIntake += item.Calories;
        //         ConsumptionHistory.Add(item);
        //         Console.WriteLine($"{item.Name}\nCalories: {item.Calories}\nSpicy: {item.IsSpicy}\nSweet: {item.IsSweet}");
        //         Console.WriteLine($"Ninja's Total Calories: {calorieIntake}");
                
                
        //     }
        //     else if (IsFull == true)
        //     {
        //         Console.WriteLine("This ninja is filled to the gills!!! STOP FEEDING HIM!!!");
        //         Console.WriteLine($"***** Ninja's Food History: *****");
        //         foreach (Food history in FoodHistory)
        //         {
        //             Console.WriteLine(history.Name);
        //         }
        //     }
        // }
    }
}