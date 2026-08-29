namespace Matrix.Easy;

public static class CountNegativeNumbersInASortedMatrix
{
    public static int Run(int[][] grid)
    {
        int negativeCount = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] < 0)
                {
                    negativeCount += cols - j;
                    break;
                }
            }
        }

        return negativeCount;
    }
}
