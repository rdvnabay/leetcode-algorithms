/**
 * @id         3099
 * @title      Harshad Number
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/harshad-number/
 */
namespace Math.Easy;

public static class HarshadNumber
{
    //18
    public static int Run(int x)
    {
        int total = 0;
        int value = x;

        while (value > 0)
        {
            total += value % 10;
            value /= 10;
        }

        if (value % total == 0)
            return total;

        return -1;
    }
}


