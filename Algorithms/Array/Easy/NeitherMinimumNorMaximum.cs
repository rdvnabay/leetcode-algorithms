namespace Array.Easy;

public static class NeitherMinimumNorMaximum
{
    public static int Run(int[] nums)
    {
        if (nums.Length < 3)
            return -1;

        System.Array.Sort(nums);
        return nums[1];
    }
}
