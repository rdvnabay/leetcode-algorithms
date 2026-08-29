/**
 * @id         566
 * @title      Reshape the Matrix
 * @topic      Matrix
 * @difficulty Easy
 * @link       https://leetcode.com/problems/reshape-the-matrix/
 */
namespace Matrix.Easy;

public static class ReshapeTheMatrix
{
    public static int[][] Run(int[][] mat, int r, int c)
    {
        int[][] result = new int[r][];
        int rows = mat.Length;
        int cols = mat[0].Length;

        if (rows * cols != r * c)
            return mat;

        int srcRow = 0;
        int srcCol = 0;

        for (int i = 0; i < r; i++)
        {
            result[i] = new int[c];
            for (int j = 0; j < c; j++)
            {
                result[i][j] = mat[srcRow][srcCol];

                if (srcCol < cols - 1)
                {
                    srcCol++;
                }
                else
                {
                    srcCol = 0;
                    if (srcRow < rows - 1)
                    {
                        srcRow++;
                    }
                }
            }
        }

        return result;
    }
}


