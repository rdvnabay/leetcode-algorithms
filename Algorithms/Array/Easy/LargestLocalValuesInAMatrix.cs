namespace Array.Easy;

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
