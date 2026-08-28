namespace Array.Easy;

public static class MinimumOperationsToExceedThresholdValueI
{
    //Input: nums = [2,11,10,1,3], k = 10
    //Output: 3
    public static int Run(int[] nums, int k)
    {
        int result = 0;

        foreach (var num in nums)
        {
            if (num < k)
                result++;
        }

        return result;
    }


    //Alternative solutions
    public static int Solution2(int[] nums, int k)
    {
        return nums.Count(x => x < k);
    }
}
