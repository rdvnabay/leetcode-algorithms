namespace Algorithms.Array.Easy.Solutions;

public static class RangeAdditionII
{
    public static int Run(int m, int n, int[][] ops)
    {
        if (ops.Length == 0)
            return m * n;

        int minRow = int.MaxValue;
        int minCol = int.MaxValue;

        for (int i = 0; i < ops.Length; i++)
        {
            var rows = ops[i][0];
            var cols = ops[i][1];

            minRow = System.Math.Min(minRow, rows);
            minCol = System.Math.Min(minCol, cols);
        }

        return minRow * minCol;
    }
}
