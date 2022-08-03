using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuestions
{
    class ValidateSudoku
    {
        public static void Process()
        {
            char[][] board = new char[9][];
            board[0] = new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' };
            board[1] = new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
            board[2] = new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' };
            board[3] = new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
            board[4] = new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' };
            board[5] = new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' };
            board[6] = new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
            board[7] = new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
            board[8] = new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' };


            Console.WriteLine("Result:" + CheckValidity(board));
        }

        static bool CheckValidity(char[][] board)
        {
            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (
                            // this is for row, make sure no such row combination is present
                            !set.Add(i + ":" + board[i][j].ToString()) || 
                            // this is for column, make sure no such columna combination is present
                            !set.Add(board[i][j].ToString() + "-" + j) || 
                            // this is for box, make sure no such box combination is present
                            !set.Add((i / 3) + "|" + (j/3) + "|" + board[i][j].ToString()))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
