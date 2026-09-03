/**
 * @id         2859
 * @title      Sum of Values at Indices With K Set Bits
 * @topic      BitManipulation
 * @difficulty Easy
 * @link       https://leetcode.com/problems/sum-of-values-at-indices-with-k-set-bits/
 */
namespace BitManipulation.Easy;

public static class SumOfValuesAtIndicesWithKSetBits
{
    public static int Run(IList<int> nums, int k)
    {
        int result = 0;

        for (int i = 0; i < nums.Count; i++)
        {
            int index = i;
            int onesTotal = 0;

            while (index > 0)
            {
                int remainder = index % 2;
                if (remainder == 1)
                    onesTotal++;

                index /= 2;
            }

            if (onesTotal == k)
                result += nums[i];
        }

        return result;
    }
}
