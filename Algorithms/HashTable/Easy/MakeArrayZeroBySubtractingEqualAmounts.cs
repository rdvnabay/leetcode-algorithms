/**
 * @id         2357
 * @title      Make Array Zero by Subtracting Equal Amounts
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/make-array-zero-by-subtracting-equal-amounts/
 */
namespace HashTable.Easy;

public static class MakeArrayZeroBySubtractingEqualAmounts
{
    public static int Run(int[] nums)
    {
        int counter = 0;
        Array.Sort(nums);
        int minPositiveValueNumber = 0;

        while (true)
        {
            foreach (var num in nums)
            {
                if (num != 0)
                {
                    minPositiveValueNumber = num;
                    break;
                }
            }

            int zeroCount = 0;
            bool isChanged = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[i] = nums[i] - minPositiveValueNumber;
                    isChanged = true;
                }

                if (nums[i] == 0)
                    zeroCount++;
            }

            if (isChanged)
                counter++;

            if (zeroCount == nums.Length)
                break;
        }

        return counter;
    }
}
