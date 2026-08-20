/**
 * @id         26
 * @title      Remove Duplicates from Sorted Array
 * @topic      array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/remove-duplicates-from-sorted-array/
 */
namespace Algorithms.Array.Easy;

public class RemoveDuplicatesFromSortedArray
{
    public static int Run(int[] nums)
    {
        List<int> outputList = new();

        foreach (var item in nums)
        {
            if (!outputList.Contains(item))
                outputList.Add(item);
        }

        nums = new int[outputList.Count];
        for (int i = 0; i < outputList.Count; i++)
        {
            nums[i] = outputList[i];
        }
        return nums.Length;
    }
}


