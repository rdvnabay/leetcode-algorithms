/**
 * @id         961
 * @title      N-Repeated Element in Size 2N Array
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/n-repeated-element-in-size-2n-array/
 */
namespace Algorithms.Array.Easy;

public static class NRepeatedElementInSize2NArray
{
    public static int Run(int[] nums)
    {
        Dictionary<int, int> dict = new();

        foreach (int num in nums)
        {
            if (dict.ContainsKey(num))
            {
                return num;
            }
            else
            {
                dict[num] = 1;
            }
        }

        return -1;
    }
}


