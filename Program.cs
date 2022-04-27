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
            string gameBoard = "123456789";
            string winner = " ";

            while (gameOver == false){
                displayBoard(gameBoard);
                // int x = Convert.ToInt32(Console.ReadLine());
                gameOver = true;
            }
            
        }

        static void displayBoard(string gameBoard){
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
        }
    }
}
