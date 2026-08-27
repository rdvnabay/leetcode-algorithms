/**
 * @id         119
 * @title      Pascal's Triangle II
 * @topic      DynamicProgramming
 * @difficulty Easy
 * @link       https://leetcode.com/problems/pascals-triangle-ii/
 */
using System.Numerics;

namespace Algorithms.DynamicProgramming.Easy;

public static class PascalsTriangleII
{
    public static IList<int> Run(int rowIndex)
    {
        List<int> result = new();
        var rowIndexFactorial = Factorial(rowIndex);

        for (int i = 0; i <= rowIndex; i++)
        {
            var value = rowIndexFactorial / (Factorial(i) * Factorial(rowIndex - i));
            result.Add((int)value);
        }
        return result;
    }

    static BigInteger Factorial(int n)
    {
        BigInteger result = 1;

        for (int i = 2; i <= n; i++)
            result *= i;

        return result;
    }
}


