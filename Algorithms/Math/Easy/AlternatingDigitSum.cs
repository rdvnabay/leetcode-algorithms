/**
 * @id         2544
 * @title      Alternating Digit Sum
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/alternating-digit-sum/
 */
namespace Math.Easy;

public static class AlternatingDigitSum
{
    public static int Run(int n)
    {
        int total = 0;
        string numStr = n.ToString();

        for (int i = 0; i < numStr.Length; i += 2)
            total += numStr[i] - '0';

        for (int i = 1; i < numStr.Length; i += 2)
            total -= numStr[i] - '0';

        return total;
    }
}


