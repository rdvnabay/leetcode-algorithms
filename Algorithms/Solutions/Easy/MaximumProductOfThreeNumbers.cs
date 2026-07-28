namespace Algorithms.Solutions.Easy;

public class MaximumProductOfThreeNumbers
{
    public static int Run(int[] nums)
    {
        Array.Sort(nums);
        int lastIndex = nums.Length - 1;

        var result1 = nums[0] * nums[1] * nums[lastIndex];
        var result2 = nums[lastIndex - 2] * nums[lastIndex - 1] * nums[lastIndex];

        return Math.Max(result1, result2);
    }
}
