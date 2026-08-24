namespace Array.Easy;

public static class Convert1DArrayInto2DArray
{
    public static int[][] Run(int[] original, int m, int n)
    {
        if (m * n != original.Length)
            return [];

        int[][] result = new int[m][];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = new int[n];
        }

        int index = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i][j] = original[index];
                index++;
            }
        }

        return result;
    }
}
