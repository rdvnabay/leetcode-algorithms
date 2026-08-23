namespace Greedy.Easy;

public static class MaximumSumWithExactlyKElements
{
    public static int Run(int[] nums, int k)
    {
        int max = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max)
                max = nums[i];
        }

        return ((max + k - 1) + max) * k / 2;
    }
}
