using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string PlayerTurn = "X";
            bool PlayerWon = false;

            string[][] board = new string[3][];

            board[0] = new string[] {"","",""};
            board[1] = new string[] {"","",""};
            board[2] = new string[] {"","",""};

            int column = -1;
            int row = -1;
            askForInput(PlayerWon, board, PlayerTurn, column, row);
            
        }

        public static void askForInput(bool PlayerWon, string[][] board, string PlayerTurn, int row, int column)
        {
            while (PlayerWon == false)
            {
                PlayerTurn = (PlayerTurn == "X") ? "O" : "X";
                //call player turn
                Console.WriteLine(PlayerTurn + " is your turn");
                Console.WriteLine("Enter a row");
                row = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine("Enter a column");
                column = int.Parse(Console.ReadLine()) - 1;

                board[row][column] = PlayerTurn;
                

                checkPlayerWin(PlayerWon, board, PlayerTurn);
            }
        }

        public static void checkPlayerWin(bool PlayerWon, string [][] board, string PlayerTurn)
        {
            PlayerWon = IsPlayerwin(board, PlayerTurn);
            
        }

        static bool IsPlayerwin(string [][] board, string PlayerTurn)
        {
            if (PlayerTurn == board[0][0] && PlayerTurn == board[0][1] && PlayerTurn == board[0][2])
            {
                Console.WriteLine($"{PlayerTurn} You have Won");
                Console.ReadLine();
                return true;
            }
            else if (PlayerTurn == board[1][0] && PlayerTurn == board[1][1] && PlayerTurn == board[1][2])
            {
                Console.WriteLine($"{PlayerTurn} You have Won");
                Console.ReadLine();
                return true;
            }
            else if (PlayerTurn == board[2][0] && PlayerTurn == board[2][1] && PlayerTurn == board[2][2])
            {
                Console.WriteLine($"{PlayerTurn} You have Won");
                Console.ReadLine();
                return true;
            }
            else if (PlayerTurn == board[0][0] && PlayerTurn == board[1][0] && PlayerTurn == board[2][0])
            {
                Console.WriteLine($"{PlayerTurn} You have Won");
                Console.ReadLine();
                return true;
            }
            else if (PlayerTurn == board[0][1] && PlayerTurn == board[1][1] && PlayerTurn == board[2][1])
            {
                Console.WriteLine($"{PlayerTurn} You have Won");
                Console.ReadLine();
                return true;
            }
            else if (PlayerTurn == board[0][2] && PlayerTurn == board[1][2] && PlayerTurn == board[2][2])
            {
                Console.WriteLine($"{PlayerTurn} You have Won");
                Console.ReadLine();
                return true;
            }
            else if (PlayerTurn == board[0][0] && PlayerTurn == board[1][1] && PlayerTurn == board[2][2])
            {
                Console.WriteLine($"{PlayerTurn} You have Won");
                Console.ReadLine();
                return true;
            }
            else if (PlayerTurn == board[0][2] && PlayerTurn == board[1][1] && PlayerTurn == board[2][0])
            {
                Console.WriteLine($"{PlayerTurn} You have Won");
                Console.ReadLine();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
