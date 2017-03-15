using System;

namespace _2Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal mealcost = decimal.Parse(Console.ReadLine());
            decimal tipPercent = decimal.Parse(Console.ReadLine());
            decimal taxPercent = decimal.Parse(Console.ReadLine());

            decimal tip = mealcost * (tipPercent / 100);
            Console.WriteLine(tip);
            decimal tax = mealcost * (taxPercent / 100);
            Console.WriteLine(tax);
            decimal totalCost = mealcost + tip + tax;
            Console.WriteLine(totalCost);
            var totalRoundedCost = Math.Round(totalCost, MidpointRounding.AwayFromZero);
            Console.WriteLine("The total meal cost is {0} dollars.",totalRoundedCost);
        }
    }
}
