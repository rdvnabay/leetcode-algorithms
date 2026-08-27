/**
 * @id         561
 * @title      Array Partition
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/array-partition/
 */
namespace Algorithms.Array.Easy;

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


