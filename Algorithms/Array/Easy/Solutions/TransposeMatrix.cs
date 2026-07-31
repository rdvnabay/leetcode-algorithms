namespace Algorithms.Array.Easy.Solutions;

public static class TransposeMatrix
{
    public static int[][] Run(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int[][] result = new int[cols][];

        for (int i = 0; i < result.Length; i++)
            result[i] = new int[rows];

        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                result[i][j] = matrix[j][i];
            }
        }

        return result;
    }
}
