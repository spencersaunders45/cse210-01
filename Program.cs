/*
    Author: Spencer Saunders
    Assignment: Tic Tak Toe/CSE210-01
*/

using System;
using System.Collections.Generic;

namespace cse210_01{
    class Program{
        static void Main(string[] args)
        {
            bool gameOver = false;
            char[] gameBoard = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};
            List<int> oMoves = new List<int>();
            List<int> xMoves = new List<int>();

            while (gameOver == false){
                displayBoard(gameBoard);

                Console.Write("x\'s turn to choose a square(1-9): ");
                int xMove = Convert.ToInt32(Console.ReadLine()) - 1;
                gameBoard = addMove(gameBoard, xMove, 'x', ref gameOver);
                
                displayBoard(gameBoard);
                if (gameOver == true){
                    break;
                }

                Console.Write("o\'s turn to choose a square(1-9): ");
                int oMove = Convert.ToInt32(Console.ReadLine()) - 1;
                gameBoard = addMove(gameBoard, oMove, 'o', ref gameOver);
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

        static char[] addMove(char[] gameBoard, int move, char player, ref bool gameOver){
            if (!gameBoard[move].Equals("x") || !gameBoard[move].Equals("o")){
                if (player.Equals('o')){
                    gameBoard[move] = 'o';
                } else if (player.Equals('x')){
                    gameBoard[move] = 'x';
                }
            }

            checkWinner(ref gameOver, gameBoard);

            return gameBoard;
        }

        static void checkWinner(ref bool gameOver, char[] gameBoard){
            int xCount = 0;
            int oCount = 0;
            int[,] possibleWins = new int[7,3] {{1,4,7}, {2,5,8}, {1,2,3}, {4,5,6}, {7,8,9}, {1,5,9}, {3,5,7}};
            
        }

    }
}
