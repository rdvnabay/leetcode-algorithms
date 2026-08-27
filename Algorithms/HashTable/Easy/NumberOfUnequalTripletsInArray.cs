/**
 * @id         2475
 * @title      Number of Unequal Triplets in Array
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/number-of-unequal-triplets-in-array/
 */
namespace HashTable.Easy;

public static class NumberOfUnequalTripletsInArray
{
    public static int Run(int[] nums)
    {
        int counter = 0;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] != nums[j] && nums[i] != nums[k] && nums[j] != nums[k])
                        counter++;
                }
            }
        }

        return counter;
    }
}
