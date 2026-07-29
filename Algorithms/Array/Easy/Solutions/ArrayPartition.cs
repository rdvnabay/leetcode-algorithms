namespace Algorithms.Array.Easy.Solutions;

public class ArrayPartition
{
    public static int Run(int[] nums)
    {
        int total = 0;
        System.Array.Sort(nums);

        for (int i = 0; i < nums.Length; i += 2)
            total += nums[i];
        
        return total;
    }
}
