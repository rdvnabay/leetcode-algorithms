/**
 * @id         2160
 * @title      Minimum Sum of Four Digit Number After Splitting Digits
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/minimum-sum-of-four-digit-number-after-splitting-digits/
 */
namespace Algorithms.Math.Easy;

public static class MinimumSumOfFourDigitNumberAfterSplittingDigits
{
    public static int Run(int num)
    {
        int[] digits = new int[4];
        int i = 0;

        while (num > 0)
        {
            digits[i] = num % 10;
            num = num / 10;
            i++;
        }

        System.Array.Sort(digits);
        var num1 = (digits[0] * 10) + digits[3]; 
        var num2 = (digits[1] * 10) + digits[2]; 

        return num1 + num2;
    }
}


