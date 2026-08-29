/**
 * @id         73
 * @title      Set Matrix Zeroes
 * @topic      Matrix
 * @difficulty Medium
 * @link       https://leetcode.com/problems/set-matrix-zeroes/
 */
namespace Matrix.Medium;

public static class SetMatrixZeroes
{
    public static void Run(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        HashSet<int> zerosRow = new();
        HashSet<int> zerosCol = new();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i][j] == 0)
                {
                    if (!zerosRow.Contains(i))
                        zerosRow.Add(i);

                    if (!zerosCol.Contains(j))
                        zerosCol.Add(j);
                }
            }
        }

        foreach (var row in zerosRow)
        {
            for (int j = 0; j < cols; j++)
                matrix[row][j] = 0;
        }

        foreach (var col in zerosCol)
        {
            for (int j = 0; j < rows; j++)
                matrix[j][col] = 0;
        }
    }
}


