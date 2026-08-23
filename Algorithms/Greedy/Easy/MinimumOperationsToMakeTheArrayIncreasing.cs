namespace Greedy.Easy;

public static class MinimumOperationsToMakeTheArrayIncreasing
{
    public static int Run(int[] nums)
    {
        int total = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] >= nums[i + 1])
            {
                int increaseCount = (nums[i] - nums[i + 1]) + 1;
                nums[i + 1] += increaseCount;
                total += increaseCount;
            }
        }

        return total;
    }
}
