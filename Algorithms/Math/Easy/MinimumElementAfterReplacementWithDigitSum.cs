/**
 * @id         3300
 * @title      Minimum Element After Replacement With Digit Sum
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/minimum-element-after-replacement-with-digit-sum/
 */
namespace Math.Easy;

public static class MinimumElementAfterReplacementWithDigitSum
{
    //10,12,13,14
    public static int Run(int[] nums)
    {
        int minValue = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            int total = 0;

            while (num > 0)
            {
                total += num % 10;
                num /= 10;
            }

            if (total < minValue)
                minValue = total;
        }

        return minValue;
    }
}


