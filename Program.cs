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
                gameBoard = addMove(gameBoard, xMove, 'x', ref gameOver, ref xMoves);
                
                displayBoard(gameBoard);
                if (gameOver == true){
                    break;
                }

                Console.Write("o\'s turn to choose a square(1-9): ");
                int oMove = Convert.ToInt32(Console.ReadLine()) - 1;
                gameBoard = addMove(gameBoard, oMove, 'o', ref gameOver, ref oMoves);
            }
            
            Console.WriteLine("Game over");
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

        static char[] addMove(char[] gameBoard, int move, char player, ref bool gameOver, ref List<int> moveList){
            if (!gameBoard[move].Equals("x") || !gameBoard[move].Equals("o")){
                if (player.Equals('o')){
                    gameBoard[move] = 'o';
                    moveList.Add(move + 1);
                } else if (player.Equals('x')){
                    gameBoard[move] = 'x';
                    moveList.Add(move + 1);
                }
            }

            checkWinner(ref gameOver, gameBoard, moveList);

            return gameBoard;
        }

        static void checkWinner(ref bool gameOver, char[] gameBoard, List<int> moveList){
            if (moveList.Count >= 3){
                // Finds if player won game
                int[,] possibleWins = new int[7,3] {{1,4,7}, {2,5,8}, {1,2,3}, {4,5,6}, {7,8,9}, {1,5,9}, {3,5,7}};
                for (int i = 0; i < 7; i++){
                    if ( moveList.Contains(possibleWins[i,0]) && moveList.Contains(possibleWins[i,1]) && moveList.Contains(possibleWins[i,2]) ){
                        gameOver = true;
                        return;
                    }
                }

                // Finds if game ended in tie
                int endGame = 0;
                for (int i = 0; i < gameBoard.Length; i++){
                    if (gameBoard[i] == 'o' || gameBoard[i] == 'x'){
                        endGame++;
                    }
                    if (endGame == 9){
                        gameOver = true;
                        return;
                    }
                }
            }
        }


    }
}
