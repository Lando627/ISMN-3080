// Landon Holloway (lah0084)
// ISMN 3080 Fall 2023 PA3

using System;

namespace moneySaved 
{
    class savingPennies
    {
       
        static void Main(string[] args)
        {
            getInput();
            
        }

        // Module where we are getting user input and checking for input validation. 
        static void getInput()
        {   

            Console.WriteLine("Enter the number of days: ");

            if(int.TryParse(Console.ReadLine(), out int userIn) && userIn >= 1)
            {
                getPennyCal(userIn);
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");

            }
        }


        //Module where we calculate the amount of money saved and total days.
        //Calculations are displayed in a rough table.
        
        static void getPennyCal(int userIn)
        {   
            Console.WriteLine("Day        Amount");
            Console.WriteLine("----------------- ");
            
            double total = 0.01;
            for (int day = 1; day <= userIn; day++)
            {
                Console.WriteLine($"{day, 2}        {total}");
                total *= 2;

            }

        }

            

    }

}