/**
 * @id         41
 * @title      First Missing Positive
 * @topic      hash-table
 * @difficulty Hard
 * @link       https://leetcode.com/problems/first-missing-positive/
 */
namespace Algorithms.HashTable.Hard;

public static class FirstMissingPositive
{
    public static int Run(int[] nums)
    {
        int missingPositiveNumber = 1;

        int total = (nums.Length * (nums.Length + 1)) / 2;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] <= nums.Length && nums[i] > 0)
            {
                total -= nums[i];
            }
            //if (nums[i] - missingPositiveNumber == 0)
            //{
            //    missingPositiveNumber++;
            //}
        }
        var test = total;
        return missingPositiveNumber;
    }
}


