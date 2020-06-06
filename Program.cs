using System;
using iron_ninja.Models;

namespace iron_ninja
{
    class Program
    {
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
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();

            SweetTooth sweet1 = new SweetTooth("Anne");
            ConsoleYellow($"{sweet1.Name} is eating at the buffet");
            while (!sweet1.IsFull)
            {
                sweet1.Consume(buffet.Serve());
            }
            sweet1.Consume(buffet.Serve());

            SpiceHound spice1 = new SpiceHound("David");
            ConsoleYellow($"{spice1.Name} is eating at the buffet");
            while (!spice1.IsFull)
            {
                spice1.Consume(buffet.Serve());
            }
            spice1.Consume(buffet.Serve());

            ConsoleYellow($"{sweet1.Name}'s total items consumed: {sweet1.ConsumptionHistory.Count}");
            ConsoleYellow($"{spice1.Name}'s total items consumed: {spice1.ConsumptionHistory.Count}");

            if (sweet1.ConsumptionHistory.Count > spice1.ConsumptionHistory.Count)
            {
                ConsoleRed($"**********************************AND THE EATING COMPETITION GOES TO {sweet1.Name} with {sweet1.ConsumptionHistory.Count} items consumed!");
            }
            else if (spice1.ConsumptionHistory.Count > sweet1.ConsumptionHistory.Count)
            {
                ConsoleRed($"**********************************AND THE EATING COMPETITION GOES TO {spice1.Name} with {spice1.ConsumptionHistory.Count} items consumed!");
            }
            else
            {
                ConsoleRed($"**********************************AND THE EATING COMPETITION GOES TO NOBODY...IT'S A TIE!!!");
            }

        }
    }
}
