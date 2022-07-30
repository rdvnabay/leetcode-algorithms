namespace Algorithms.Solutions.Easy;

public class SingleNumber
{
    public static int Run(int[] nums)
    {
        return Solution1(nums);
        //return Solution2(nums);
    }

    // Bit manipulation
    // Runtime: 138 ms	
    // Memory: 40.1 MB
    private static int Solution1(int[] nums)
    {
        var output = 0;
        foreach (var num in nums)
        {
            output = output ^ num;
        }

        return output;
    }

    // Runtime: 182 ms	
    // Memory: 40.1 MB
    private static int Solution2(int[] nums)
    {
        int output = 0;
        Array.Sort(nums);

        if (nums.Length == 1)
            return nums[0];

        for (int i = 0; i < nums.Length; i += 2)
        {
            if (nums.Length - i == 1)
            {
                output = nums[nums.Length - 1];
                break;
            }

            if (nums[i] != nums[i + 1])
            {
                output = nums[i];
                break;
            }
        }
        return output;
    }
}
