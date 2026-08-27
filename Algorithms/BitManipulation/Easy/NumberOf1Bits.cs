/**
 * @id         191
 * @title      Number of 1 Bits
 * @topic      BitManipulation
 * @difficulty Easy
 * @link       https://leetcode.com/problems/number-of-1-bits/
 */
namespace Algorithms.BitManipulation.Easy;

public static class NumberOf1Bits
{
    public static int Run(int n)
    {
        List<int> bits = new();
        do
        {
            bits.Add(n % 2);
            n = n / 2;
        }
        while (n >= 2);
        bits.Add(n);
        int countOfOnes = bits.Where(x => x == 1).Count();
        return countOfOnes;
    }
}


