using System;
using System.Collections.Generic;
using System.Text;

namespace Studio
{
    public class Circle
    {
        public static double AskRadius()
        {
            Console.WriteLine("What is the radius of the circle?");
            string radius = Console.ReadLine();
            double dubRadius = double.Parse(radius);
            while (dubRadius <= 0)
            {
                Console.WriteLine("Please only enter a positive number.");
                Console.WriteLine("What is the radius of the circle?");
                radius = Console.ReadLine();
                dubRadius = double.Parse(radius);
            }
            double area = Math.Pow(dubRadius, dubRadius) * Math.PI;
            return area;


        }
    }
}
