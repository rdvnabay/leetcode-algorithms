/**
 * @id         3232
 * @title      Find if Digit Game Can Be Won
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-if-digit-game-can-be-won/
 */
namespace Math.Easy;

public static class FindIfDigitGameCanBeWon
{
    //1,2,3,4,10
    public static bool Run(int[] nums)
    {
        int singleDigit = 0;
        int doubleDigit = 0;

        foreach (var num in nums)
        {
            if (num < 10)
                singleDigit += num;
            else
                doubleDigit += num;
        }

        return singleDigit != doubleDigit;
    }
}


