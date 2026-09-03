namespace Array.Easy;

public static class DeleteGreatestValueInEachRow
{
    public static int Run(int[][] grid)
    {
        int columnIndex = grid[0].Length - 1;

        foreach (var row in grid)
            System.Array.Sort(row);

        int maxTotal = 0;
        while (columnIndex >= 0)
        {
            int max = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                max = Math.Max(max, grid[i][columnIndex]);
            }
            maxTotal += max;
            columnIndex--;
        }

        return maxTotal;
    }
}
