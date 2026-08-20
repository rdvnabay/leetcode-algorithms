/**
 * @id         3895
 * @title      Count Digit Appearances
 * @topic      array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/count-digit-appearances/
 */
namespace Array.Medium;

public static class CountDigitAppearances
{
    public static int Run(int[] nums, int digit)
    {
        int total = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];

            while (num > 0)
            {
                int remainder = num % 10;
                if (remainder == digit)
                    total++;

                num /= 10;
            }
        }

        return total;
    }
}


