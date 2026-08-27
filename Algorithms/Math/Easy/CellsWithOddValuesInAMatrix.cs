/**
 * @id         1252
 * @title      Cells with Odd Values in a Matrix
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/cells-with-odd-values-in-a-matrix/
 */
using System.Data;

namespace Algorithms.Math.Easy;

public static class CellsWithOddValuesInAMatrix
{
    public static int Run(int m, int n, int[][] indices)
    {
        int[][] matrix = new int[m][];
        int result = 0;

        for (int i = 0; i < m; i++)
            matrix[i] = new int[n];

        for (int i = 0; i < indices.Length; i++)
        {
            int row = indices[i][0];
            int col = indices[i][1];
            SetRow(matrix, row, n);
            SetColumn(matrix, col, m);
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] % 2 == 1)
                    result++;
            }
        }

        return result;
    }

    static void SetRow(int[][] matrix, int row, int n)
    {
        for (int i = 0; i < n; i++)
            matrix[row][i] += 1;
    }

    static void SetColumn(int[][] matrix, int col, int m)
    {
        for (int i = 0; i < m; i++)
            matrix[i][col] += 1;
    }
}


