// Landon Holloway (lah0084) 
// ISMN 3080 Fall 2023 Programming Assignment 4

using System; 

class diceGame
{
    static void Main()
    {
        string input;

        do
        {   //For loop to roll the die three times
            for (int i = 0; i < 3; i++)
            {
                int die = diceRoll();
                Console.WriteLine($"Roll #{i + 1} is: {die}");

            }
            //Takes user input to determine whether to continue the program or exit. 
            Console.WriteLine("Do you wish to continue or exit? Type YES to continue, NO to exit");
            input = Console.ReadLine();


        } 
        while (input.ToUpper() == "YES");

        Console.WriteLine("Exiting dice game.");


    }
    
    //diceRoll generates a random number between 1 and 6 and returns the result to be displayed in the main method.
    static int diceRoll()
    {   
        Random rand = new Random();
        return rand.Next(1, 7);
    }


}
