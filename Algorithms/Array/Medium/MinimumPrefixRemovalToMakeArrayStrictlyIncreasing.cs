namespace Array.Medium;

public static class MinimumPrefixRemovalToMakeArrayStrictlyIncreasing
{
    public static int Run(int[] nums)
    {
        int left = 0;

        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] >= nums[i + 1])
                left = i;
        }

        return left == 0 ? 0 : left + 1;
    }
}
