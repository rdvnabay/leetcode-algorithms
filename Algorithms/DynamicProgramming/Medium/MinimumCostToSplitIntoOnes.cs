/**
 * @id         3857
 * @title      Minimum Cost to Split into Ones
 * @topic      DynamicProgramming
 * @difficulty Medium
 * @link       https://leetcode.com/problems/minimum-cost-to-split-into-ones/
 */
namespace DynamicProgramming.Medium;

public static class MinimumCostToSplitIntoOnes
{
    public static int Run(int n)
    {
        return n * (n - 1) / 2;
    }
}
