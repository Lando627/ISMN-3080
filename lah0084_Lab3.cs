// Landon Holloway (lah0084) 
// ISMN 3080 Fall 2023 Lab 3
using System;

namespace TravellingCars 
{

    class TravelTime 

    {

        //Main argument that shows our numerical values, along with our calculation references. 
        //Also shows our program output with the Console.WriteLine statements. 

        static void Main(string[] args)
        {
            const int speed = 60;
            int timeOne = 5;
            int timeTwo = 2;
            int timeThree = 12; 

            int distanceOne = getD1(timeOne, speed);
            int distanceTwo = getD2(timeTwo, speed);
            int distanceThree = getD3(timeThree, speed);
        
            Console.WriteLine("Car #1 traveled " + distanceOne + " miles.");
            Console.WriteLine("Car #2 traveled " + distanceTwo + " miles.");
            Console.WriteLine("Car #3 traveled " + distanceThree + " miles.");

        }

        // Calculating distance travelled. 

        static int getD1 (int timeOne, int speed) 
        {
            int distanceOne = timeOne * speed;
            return distanceOne;

        }

        static int getD2 (int timeTwo, int speed)
        {
            int distanceTwo = timeTwo * speed;
            return distanceTwo;

        }

        static int getD3 (int timeThree, int speed)
        {
            int distanceThree = timeThree * speed;
            return distanceThree;

        }

    }

}