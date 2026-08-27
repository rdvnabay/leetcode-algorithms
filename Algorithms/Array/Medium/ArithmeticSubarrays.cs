/**
 * @id         1630
 * @title      Arithmetic Subarrays
 * @topic      Array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/arithmetic-subarrays/
 */
namespace Array.Medium;

public static class ArithmeticSubarrays
{
    public static IList<bool> Run(int[] nums, int[] l, int[] r)
    {
        bool[] result = new bool[l.Length];

        for (int i = 0; i < l.Length; i++)
        {
            int[] subArr = new int[r[i] - l[i] + 1];
            int k = 0;

            for (int j = l[i]; j <= r[i]; j++)
            {
                subArr[k] = nums[j];
                k++;
            }

            System.Array.Sort(subArr);
            int arithmeticCount = subArr[1] - subArr[0];
            bool isArithmetic = true;

            for (int m = 0; m < subArr.Length - 1; m++)
            {
                if (subArr[m] + arithmeticCount != subArr[m + 1])
                {
                    isArithmetic = false;
                    break;
                }
            }

            result[i] = isArithmetic;
        }

        return result;
    }
}


