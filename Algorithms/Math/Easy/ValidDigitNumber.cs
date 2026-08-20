/**
 * @id         3908
 * @title      Valid Digit Number
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/valid-digit-number/
 */
namespace Math.Easy;

public static class ValidDigitNumber
{
    public static bool Run(int n, int x)
    {
        char firstDigit = n.ToString()[0];

        if (firstDigit - '0' == x)
            return false;

        while (n > 0)
        {
            int remainder = n % 10;

            if (remainder == x)
                return true;

            n /= 10;
        }

        return false;
    }
}


