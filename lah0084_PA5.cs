// Landon Holloway (lah0084) 
// ISMN 3080 Fall 2023 PA 5

namespace ticTacToe
{
    class paFive
    {
        static void Main()
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
            }
            else
            {
                Console.WriteLine("O wins!");
            }

            


        }

    }

}