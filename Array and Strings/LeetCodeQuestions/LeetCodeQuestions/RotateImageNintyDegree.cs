using System;

namespace LeetCodeQuestions
{
    class RotateImageNintyDegree
    {
        public static void Process()
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 2, 3 };
            matrix[1] = new int[] { 4, 5, 6 };
            matrix[2] = new int[] { 7, 8, 9 };

            int m = matrix.Length;

            PrintMatrix(matrix);

            Console.WriteLine("Performing Transpose!!");

            DoingInPlaceChange(matrix);

            PrintMatrix(matrix);

            ReversingArray(matrix);

            //for (int i = 0; i < matrix.Length; i++)
            //{
            //  Array.Reverse(matrix[i]);
            //}

            PrintMatrix(matrix);
        }

        static void ReversingArray(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0, k = matrix.Length - 1; j < matrix.Length / 2; j++, k--)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][k];
                    matrix[i][k] = temp;
                }
            }
        }

        static void DoingInPlaceChange(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i + 1; j < matrix.Length; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
        }

        static void UsingAdditonalArray(int[][] matrix)
        {

            int[][] temp = new int[3][];
            temp[0] = new int[3];
            temp[1] = new int[3];
            temp[2] = new int[3];

            int m = matrix.Length;
            // transpose
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    temp[i][j] = matrix[j][i];
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i][j] = temp[i][j];
                }

            }

            PrintMatrix(matrix);
        }

        static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    Console.Write(matrix[i][j] + "  ");
                }
                Console.WriteLine("");
            }
        }
    }
}
