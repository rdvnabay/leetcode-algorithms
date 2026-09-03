namespace Array.Easy;

public static class DivideAnArrayIntoSubarraysWithMinimumCostI
{
    public static int Run(int[] nums)
    {
        int total = 0;
        List<int> list = nums.ToList();

        for (int i = 0; i < 2; i++)
        {
            int min = list.Min();
            total += min;
            list.Remove(min);
        }

        total += list[0];
        return total;
    }
}
