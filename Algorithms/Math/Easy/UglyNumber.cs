/**
 * @id         263
 * @title      Ugly Number
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/ugly-number/
 */
namespace Algorithms.Math.Easy;

public static class UglyNumber
{
    public static bool Run(int n)
    {
        if (n <= 0) return false;
        if (n == 1) return true;

        int counter = 2;
        return Recursive(n, counter);
    }

    static bool Recursive(int n, int counter)
    {
        if (n == 1)
            return true;

        if (counter > 5)
            return false;

        if (n % counter == 0)
            n = n / counter;
        else
            counter++;

        return Recursive(n, counter);
    }
}


