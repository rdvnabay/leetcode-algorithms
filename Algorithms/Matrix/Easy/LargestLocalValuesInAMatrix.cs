/**
 * @id         2373
 * @title      Largest Local Values in a Matrix
 * @topic      Matrix
 * @difficulty Easy
 * @link       https://leetcode.com/problems/largest-local-values-in-a-matrix/
 */
namespace Matrix.Easy;

public static class LargestLocalValuesInAMatrix
{
    public static int[][] Run(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        int[][] result = new int[rows - 2][];

        for (int i = 0; i < result.Length; i++)
            result[i] = new int[cols - 2];

        List<(int, int)> res = new();
        for (int i = 0; i < rows - 2; i++)
        {
            for (int j = 0; j < cols - 2; j++)
            {
                res.Add((i, j));
            }
        }

        return null;
    }
}
