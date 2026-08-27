/**
 * @id         231
 * @title      Power of Two
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/power-of-two/
 */
namespace Algorithms.Math.Easy;

public static class PowerOfTwo
{
    public static bool Run(int n)
    {
        if (n <= 0) return false;
        if (n == 1) return true;

        double number = n;

        while (number > 2)
            number = number / 2;

        return number % 2 == 0 ? true : false;

    }
}


