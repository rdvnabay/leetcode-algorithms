/**
 * @id         1551
 * @title      Minimum Operations to Make Array Equal
 * @topic      Math
 * @difficulty Medium
 * @link       https://leetcode.com/problems/minimum-operations-to-make-array-equal/
 */
namespace Math.Medium;

public static class MinimumOperationsToMakeArrayEqual
{
    public static int Run(int n)
    {
        int total = 0;

        for (int i = 1; i <= n * 2 - 1; i += 2)
        {
            if (n < i)
                break;

            total += n - i;
        }
        
        return total;
    }
}
