// Landon Holloway (lah0084)
// ISMN 3080 Fall 2023 Lab 6
// This Lab is based of provided pseudocode for the golf score program.

using System;
using System.IO;
using System.Runtime.InteropServices;


class golfSocre
{
    static void Main()
    {
        int menuSelection;

        do
        {
            DisplayMenu(menuSelection);

            menuSelection

        }

    }

    static void DisplayMenu(int selection)
    {   
        Console.WriteLine("   Springfork Amateur Golf Club.");
        Console.WriteLine("1. Create new scores file.");
        Console.WriteLine("2. Append to scores file.");
        Console.WriteLine("3. Show scores file.");
        Console.WriteLine("4. Exit the program.");
        Console.WriteLine("Enter your selection.");
        int input = Convert.ToInt32(Console.ReadLine());
        
        
        while(selection < 1 || selection > 4)
        {
           Console.WriteLine("That is an invalid selection.");
           Console.WriteLine("Enter 1, 2, 3, or 4.");
           int userIn = Convert.ToInt32(Console.ReadLine());  

        }
        

    }

    static void ShowFile()
    {
        int count = 0;
        int readScore;
        string readPlayer;

    }

}