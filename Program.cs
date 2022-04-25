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
            string gameBoard = "1|2|3\n-+-+-\n4|5|6\n-+-+-\n7|8|9";

            while (gameOver == false){
                
            }
            
            displayBoard(gameBoard);
        }

        static void displayBoard(string gameBoard){
        for (int i = 0; i < gameBoard.Length; i++){
                Console.Write(gameBoard[i]);
            }
        }
    }
}
