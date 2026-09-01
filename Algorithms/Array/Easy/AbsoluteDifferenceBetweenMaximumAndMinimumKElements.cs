namespace Array.Easy;

public static class AbsoluteDifferenceBetweenMaximumAndMinimumKElements
{
    public static int Run(int[] nums, int k)
    {
        System.Array.Sort(nums);
        int maxTotal = 0;
        int minTotal = 0;

        for (int i = 0; i < k; i++)
        {
            minTotal += nums[i];
            maxTotal += nums[nums.Length + i - k];
        }

        return Math.Abs(maxTotal - minTotal);
    }
}
