using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2
{
    class Program
    {
        static void Main(string[] args)
        {
            string PlayerTurn = "x";
            bool PlayerWon = false;

            string[][] Board = new string[3][];
            Board[0] = new string[] { "", "", "" };
            Board[1] = new string[] { "", "", "" };
            Board[2] = new string[] { "", "", "" };

            int column = -1;
            int row = -1;

            AskForInput(PlayerWon, PlayerTurn, Board, row, column);

        }

        public static void AskForInput(bool PlayerWon, string PlayerTurn, string[][] Board, int row, int column )
        {
            while (PlayerWon == false)
            {
                PlayerTurn = (PlayerTurn == "x") ? "o" : "x";

                Console.WriteLine($"{PlayerTurn} is your turn");
                Console.WriteLine("Please enter a row");
                row = Convert.ToInt32(Console.ReadLine()) - 1;

                Console.WriteLine("Please enter a column");
                column = int.Parse(Console.ReadLine()) - 1;

                Board[row][column] = PlayerTurn;

                CheckPlayerWin(PlayerWon, Board, PlayerTurn);
            }
        }

        public static void CheckPlayerWin(bool PlayerWon, string[][] Board, string PlayerTurn)
        {
            PlayerWon = DidPlayerWin(Board, PlayerTurn);
        }
        static bool DidPlayerWin(string[][] Board, string PlayerTurn)
        {
            if (PlayerTurn == Board[0][0] && PlayerTurn == Board[0][1] && PlayerTurn == Board[0][2])
            {
                Console.WriteLine($"{PlayerTurn} You have Won");
                Console.ReadLine();
                return true;
            }
            else if (PlayerTurn == Board[1][0] && PlayerTurn == Board[1][1] && PlayerTurn == Board[1][2])
            {
                Console.WriteLine($"{PlayerTurn} You have Won");
                Console.ReadLine();
                return true;
            }
            else if (PlayerTurn == Board[2][0] && PlayerTurn == Board[2][1] && PlayerTurn == Board[2][2])
            {
                Console.WriteLine($"{PlayerTurn} You have Won");
                Console.ReadLine();
                return true;
            }
            else if (PlayerTurn == Board[0][0] && PlayerTurn == Board[1][0] && PlayerTurn == Board[2][0])
            {
                Console.WriteLine($"{PlayerTurn} You have Won");
                Console.ReadLine();
                return true;
            }
            else if (PlayerTurn == Board[0][1] && PlayerTurn == Board[1][1] && PlayerTurn == Board[2][1])
            {
                Console.WriteLine($"{PlayerTurn} You have Won");
                Console.ReadLine();
                return true;
            }
            else if (PlayerTurn == Board[0][2] && PlayerTurn == Board[1][2] && PlayerTurn == Board[2][2])
            {
                Console.WriteLine($"{PlayerTurn} You have Won");
                Console.ReadLine();
                return true;
            }
            else if (PlayerTurn == Board[0][0] && PlayerTurn == Board[1][1] && PlayerTurn == Board[2][2])
            {
                Console.WriteLine($"{PlayerTurn} You have Won");
                Console.ReadLine();
                return true;
            }
            else if (PlayerTurn == Board[0][2] && PlayerTurn == Board[1][1] && PlayerTurn == Board[2][0])
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
