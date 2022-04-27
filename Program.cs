/*
    Spencer Saunders
    CSE 210 - Tic Tak Toe
*/

using System;

namespace cse210_01{
    class Program{
        static void Main(string[] args)
        {
            bool gameOver = false;
            char[] gameBoard = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};
            string winner = " ";

            while (gameOver == false){
                displayBoard(gameBoard);

                Console.Write("x\'s turn to choose a square(1-9): ");
                int xMove = Convert.ToInt32(Console.ReadLine()) - 1;
                gameBoard = addMove(gameBoard, xMove, 'x', ref winner);
                
                displayBoard(gameBoard);

                Console.Write("o\'s turn to choose a square(1-9): ");
                int oMove = Convert.ToInt32(Console.ReadLine()) - 1;
                gameBoard = addMove(gameBoard, oMove, 'o', ref winner);
            }
            
        }

        static void displayBoard(char[] gameBoard){
            for (int i = 0; i < gameBoard.Length; i++){
                if (i % 3 == 0 && i > 0){
                    Console.WriteLine("\n-+-+-");
                    Console.Write(gameBoard[i]);
                    Console.Write("|");
                    continue;
                }
                Console.Write(gameBoard[i]);
                if ((i + 1) % 3 == 0){
                    continue;
                }
                Console.Write("|");
            }
            Console.Write("\n\n");
        }

        static char[] addMove(char[] gameBoard, int move, char player, ref string winner){
            if (!gameBoard[move].Equals("x") || !gameBoard[move].Equals("o")){
                if (player.Equals('o')){
                    gameBoard[move] = 'o';
                } else if (player.Equals('x')){
                    gameBoard[move] = 'x';
                }
            }

            return gameBoard;
        }

    }
}
