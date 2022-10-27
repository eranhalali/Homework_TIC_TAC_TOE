using System;

namespace Homework_Lec9
{
    internal class Program
    {
        //Making array of the board, numbers 1 to 9. [number 0 is not used]
        static char[] numOfCell = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; // By default player 1 is set.
        static int choice;
        static int flag = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("////////////Welcome to Tic_tac_toe game////////////");
                Console.WriteLine("////////////There are some rules:////////////");
                Console.WriteLine("////////////The game is played on a grid that's 3 squares by 3 squares.////////////");
                Console.WriteLine("////////////The first player to get 3 of her marks in a row (up, down, across, or diagonally) is the winner.////////////");
                Console.WriteLine("////////////When all 9 squares are full, the game is over.////////////");
                Console.WriteLine("////////////By default Player1 (X), Player2 (0)////////////");
                Console.WriteLine("\n");
                if (player % 2 == 0) // checking the chance of the player..
                {
                    Console.WriteLine("Player 2 Turn:");
                }
                else
                {
                    Console.WriteLine("Player 1 Turn:");
                }
                Console.WriteLine("\n");
                Board(); //printing the board
                Console.WriteLine("\n");
                Console.Write("Enter your choice: ");
                int.TryParse(Console.ReadLine(), out int choice);
                if (numOfCell[choice] != 'X' && numOfCell[choice] != '0')
                {
                    if (player % 2 == 0) // if chance is of player 2 then mark 0, else mark X
                    {
                        numOfCell[choice] = '0';
                        player++;
                    }
                    else
                    {
                        numOfCell[choice] = 'X';
                        player++;
                    }
                }
                //else
                //{
                    //Console.WriteLine("Sorry the row " + choice + "is already marked with " + numOfCell[choice]);
                  //  Console.WriteLine("\n");
                //}
                flag = CheckWinner(); // calling to the function and checking the winner.
            }
            while (flag != 1 && flag != -1);
            Console.Clear(); // clearing the console
            Board(); // printing the board again
            if (flag == 1) // if the flag value is 1 then someone has to win or means who played marked last time which has win..
            {
                //Console.WriteLine("Player " + (player % 2) + 1 + " has won");
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else // if the flag value is -1 means the match will be draw, no one is winner.
            {
                Console.WriteLine("The game is Draw!");
            }
            Console.ReadLine();
        }

        //Function of the board
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  " + numOfCell[1] + "  |  " + numOfCell[2] + "  |  " + numOfCell[3] + " ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  " + numOfCell[4] + "  |  " + numOfCell[5] + "  |  " + numOfCell[6] + " ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  " + numOfCell[7] + "  |  " + numOfCell[8] + "  |  " + numOfCell[9] + " ");
            Console.WriteLine("     |     |      ");
        }

        //Function of checking that any playter has won or not
        private static int CheckWinner()
        {
            //Checking for first row >
            if (numOfCell[1] == numOfCell[2] && numOfCell[2] == numOfCell[3])
            {
                return 1;
            }
            //Checking for second row >
            else if (numOfCell[4] == numOfCell[5] && numOfCell[5] == numOfCell[6])
            {
                return 1;
            }
            //Checking for third row >
            else if (numOfCell[6] == numOfCell[7] && numOfCell[7] == numOfCell[8])
            {
                return 1;
            }
            //Checking for first column
            else if (numOfCell[1] == numOfCell[4] && numOfCell[4] == numOfCell[7])
            {
                return 1;
            }
            //Checking for second column
            else if (numOfCell[2] == numOfCell[5] && numOfCell[5] == numOfCell[8])
            {
                return 1;
            }
            //Checking for third column
            else if (numOfCell[3] == numOfCell[6] && numOfCell[6] == numOfCell[9])
            {
                return 1;
            }
            else if (numOfCell[1] == numOfCell[5] && numOfCell[5] == numOfCell[9])
            {
                return 1;
            }
            else if (numOfCell[3] == numOfCell[5] && numOfCell[5] == numOfCell[7])
            {
                return 1;
            }
            else if (numOfCell[1] != '1' && numOfCell[2] != '2' && numOfCell[3] != '3' && numOfCell[4] != '4' && numOfCell[5] != '5' && numOfCell[6] != '6' && numOfCell[7] != '7' && numOfCell[8] != '8' && numOfCell[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }
}