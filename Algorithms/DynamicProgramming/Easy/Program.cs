
namespace Algorithms.DynamicProgramming.Easy;

public static class DynamicProgrammingEasyRunner
{
    public static void Run()
    {
        // 70: Climbing Stairs
        ClimbingStairs.Run(4);
        // 119: Pascal's Triangle II
        PascalsTriangleII.Run(13);
        // 121: Best Time to Buy and Sell Stock
        BestTimeToBuyAndSellStock.Run(new int[] { 3, 2, 6, 5, 0, 3 });
        // 746: Min Cost Climbing Stairs
        MinCostClimbingStairs.Run(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 });
    }
}