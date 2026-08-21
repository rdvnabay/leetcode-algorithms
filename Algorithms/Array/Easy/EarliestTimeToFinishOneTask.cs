namespace Array.Easy;

public static class EarliestTimeToFinishOneTask
{
    public static int Run(int[][] tasks)
    {
        int minValue = int.MaxValue;

        for (int i = 0; i < tasks.Length; i++)
        {
            int total = 0;

            for (int j = 0; j < tasks[i].Length; j++)
            {
                total += tasks[i][j];
            }

            if (total < minValue)
                minValue = total;
        }

        return minValue;
    }
}
