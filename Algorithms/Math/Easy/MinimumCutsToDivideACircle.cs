/**
 * @id         2481
 * @title      Minimum Cuts to Divide a Circle
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/minimum-cuts-to-divide-a-circle/
 */
namespace Math.Easy;

public static class MinimumCutsToDivideACircle
{
    public static int Run(int n)
    {
        if (n == 1)
            return 0;
        
        return n % 2 == 0 ? n / 2 : n;
    }
}


