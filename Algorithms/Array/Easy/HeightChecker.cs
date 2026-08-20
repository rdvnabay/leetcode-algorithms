/**
 * @id         1051
 * @title      Height Checker
 * @topic      array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/height-checker/
 */
namespace Algorithms.Array.Easy;

public static class HeightChecker
{
    public static int Run(int[] heights)
    {
        int count = 0;

        int[] expected = (int[])heights.Clone();
        System.Array.Sort(expected);

        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] != expected[i])
                count++;
        }

        return count;
    }
}


