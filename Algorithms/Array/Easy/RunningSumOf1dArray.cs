namespace Array.Easy;

public static class RunningSumOf1dArray
{
    public static int[] Run(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
            nums[i] = nums[i - 1] + nums[i];
       
        return nums;
    }
}
