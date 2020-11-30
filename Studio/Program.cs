using System;

namespace Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            double getArea = Circle.AskRadius();
            Console.WriteLine("How many miles per gallon do you get for your car?");
            string mpg = Console.ReadLine();
            double dubMpg = double.Parse(mpg);
            double gallons = getArea / dubMpg;
            Console.WriteLine($"You would use {gallons} gallons of gas for the trip.");




        }
    }
}
