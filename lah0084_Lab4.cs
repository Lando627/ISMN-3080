// Landon Holloway (lah0084) 
// ISMN 3080 Fall 2023 Lab 4

using System;


namespace Circles 
{
    class ComparingArea
    {   
        // Main method that has our small calculations, constant varialbe, if-else statements, and output.

        static void Main(string[] args)
        {
            const double pi = Math.PI;
            double radOne = getRadiusOne();
            double radTwo = getRadiusTwo();
            double areaOne = pi * Math.Pow(radOne, 2);
            double areaTwo = pi * Math.Pow(radTwo, 2);
            double aOne = Math.Round(areaOne, 3);
            double aTwo = Math.Round(areaTwo, 3);

            if (areaOne > areaTwo)
            {
                Console.WriteLine("The first circle is greater, with an area of " + aOne);
            }
            
            else if (areaTwo > areaOne)
            {
                Console.WriteLine("The second circle is greater, with an area of " + aTwo);
            }

            else if (areaOne == areaTwo)
            {
                Console.WriteLine("The areas of both circles are equal.");
            }
        }

        // This section contains our "get" methods that obtain input from the user for later use in our calculations. 
        static double getRadiusOne()
        {
            Console.WriteLine("Enter the radius of the first circle: ");
            double inputOne = Convert.ToDouble(Console.ReadLine());
            return inputOne;
        
        }

        static double getRadiusTwo()
        {
            Console.WriteLine("Enter the radius of the second circle: ");
            double inputTwo = Convert.ToDouble(Console.ReadLine());
            return inputTwo;

        }

        


    }

}
