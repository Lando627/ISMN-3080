// Landon Holloway 
// ISMN 3080 Fall 2023 Final Project

using System;
using System.IO;

class gamesProgram
{
    static void Main()
    {   
        // Menu selection method that lets the user choose which game to play and if they want to exit the program. 
        int menuSelection;

        do
        {
            DisplayMenu(out menuSelection);

            switch (menuSelection)
            {
                case 1: 
                diceGame();
                break;
                case 2:
                ticTacToe();
                break;
                case 3:
                rockPaperScissors();
                break;


            }


        }
        while(menuSelection != 4);


    }

    // Takes user input to direct them to whatever game they select. 
    // Validates that input is 1-4. 
    static void DisplayMenu(out int selection)
    {
        Console.WriteLine("   Games Program");
        Console.WriteLine("1. Dice Game");
        Console.WriteLine("2. TicTacToe");
        Console.WriteLine("3. Rock Paper Scissors");
        Console.WriteLine("4. Exit the program.");
        selection = Convert.ToInt32(Console.ReadLine());

        //Validation
        while(selection < 1 || selection > 4)
        {
            Console.WriteLine("That is an invalid selection.");
            Console.WriteLine("Enter 1, 2, 3, or 4.");
            selection = Convert.ToInt32(Console.ReadLine());

        }


    }

    // Short WriteFile method that allows the creation of data files after a game is chosen and played. 

    static void WriteFile(string name, string stats)
    {
        using (StreamWriter playerStats = new StreamWriter(name, true))
        {
            playerStats.WriteLine(stats);

        }

        

    }

    

    // Dice game that rolls for player and computer where the higher result wins. 
    // Player statistics are stored in an output file. 
    static void diceGame()
    {
        string input;
        int player = diceRoll();
        int computer = diceRoll();
        int winCount = 0;


        do
        {
            Console.WriteLine($"Player roll: {player}");
            Console.WriteLine($"Computer roll: {computer}");

            if (player < computer)
            {
                Console.WriteLine("Computer wins.");

            }
            else if (player > computer)
            {
                Console.WriteLine("Player wins.");
                winCount++;

            }
            else
            {
                Console.WriteLine("Tie game.");

            }

            WriteFile("diceStats.dat", $"Player: {player}, Wins: {winCount}");
            

            Console.WriteLine("Do you wish to continue or exit? Type YES to continue, NO to exit");
            input = Console.ReadLine();


        } 
        while (input.ToUpper() == "YES");

        


    }

    static int diceRoll()
    {   
        Random rand = new Random();
        return rand.Next(1, 7);
    }


    static void ticTacToe()
        {
            //Constants
           const int rows = 3;
           const int cols = 3;

           //Local Variables
           int player1;
           int player2;
           int indexR;
           int indexC;
           int winX = 0;
           int winO = 0;
           int playerXwin = 0;
           int playerOwin = 0;
           string[,] board = new string[rows, cols];
           int draw = 9;

            //Setting up the game board.
           for (indexR = 0; indexR < rows - 1; indexR++)
           {
                for (indexC = 0; indexC < cols - 1; indexC++)
                {
                    board[indexR, indexC] = "*";

                }
           }

            //Game Processes
           while (winX == 0 && winO == 0)
           {
                //Locations for X
                Console.WriteLine("Enter a row for X:");
                player1 = Convert.ToInt32(Console.ReadLine());
                indexR = player1 - 1;
                Console.WriteLine("Enter a column for X:");
                player1 = Convert.ToInt32(Console.ReadLine());
                indexC = player1 - 1;
                
                if (board[indexR, indexC] == "*")
                {
                    board[indexR, indexC] = "X";
                }
                
                //Locations for O
                Console.WriteLine("Enter a row for O:");
                player2 = Convert.ToInt32(Console.ReadLine());
                indexR = player2 - 1;
                Console.WriteLine("Enter a column for O:");
                player2 = Convert.ToInt32(Console.ReadLine());
                indexC = player2 - 1;

                if (board[indexR, indexC] == "*")
                {
                    board[indexR, indexC] = "O";
                }

                
                //Check for draw
                for(indexR = 0; indexR < rows - 1; indexR++)
                {
                    for(indexC = 0; indexC < cols - 1; indexC++)
                    {
                        if(board[indexR, indexC] == "*")
                        {
                            draw = 0;

                        }

                    }

                }

                if (draw == 9)
                {
                    winX = 1;
                    winO = 1;
                }

                //Displaying the board. (I had a trouble with formatting the board correctly.)
                for (indexR = 0; indexR < rows - 1; indexR++)
                {
                    for (indexC = 0; indexC < cols - 1; indexC++)
                    {
                        Console.WriteLine(board[indexR, indexC]);
                    }

                }
            }
            
            //Displaying results
            if (draw == 9)
            {
                Console.WriteLine("The game is a draw.");
            }
            else if(winX == 1)
            {
                Console.WriteLine("X wins!");
                playerXwin++;
            }
            else
            {
                Console.WriteLine("O wins!");
                playerOwin++;
            }

            


        }

        // Rock Paper Scissors Game. 
        // Rock = 1, Paper = 2, and Scissors = 3.
        // Takes user input and compares to the computer. Win/Loss/Tie is shown with Player stats being written into a file.

        static void rockPaperScissors()
        {
            int player;
            int computer;
            int playerWins = 0; 
             
            // user input
            Console.WriteLine("Enter 1 for rock, 2 for paper, or 3 for scissors");
            player = Convert.ToInt32(Console.ReadLine());
            
            // random selection for computer
            Random rand = new Random();
            computer = rand.Next(1, 4);

            if (computer == 1 && player == 2)
            {
                Console.WriteLine("Player wins.");
                playerWins++;

            }
            else if (computer == 2 && player == 3)
            {
                Console.WriteLine("Player wins.");
                playerWins++;
            }
            else if (computer == 3 && player == 1)
            {
                Console.WriteLine("Player wins.");
                playerWins++;
            }
            else if (player == computer)
            {
                Console.WriteLine("Tie game. Please Play again.");
                rockPaperScissors();

            }
            else 
            {
                Console.WriteLine("Computer wins.");

            }

            WriteFile("rpsStats.dat", $"Player: {player}, Wins: {playerWins}");




        }

        
}



