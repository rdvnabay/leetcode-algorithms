/**
 * @id         1822
 * @title      Sign of the Product of an Array
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/sign-of-the-product-of-an-array/
 */
namespace Math.Easy;

public static class SignOfTheProductOfAnArray
{
    public static int Run(int[] nums)
    {
        int negativeNumberCount = 0;

        foreach (var num in nums)
        {
            if (num == 0)
                return 0;

            if (num < 0)
                negativeNumberCount++;
        }

        return negativeNumberCount % 2 == 0 ? 1 : -1;
    }
}
