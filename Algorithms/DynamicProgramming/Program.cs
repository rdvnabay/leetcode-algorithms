// Demo runner for 5 solution files; the README is the canonical ID-sorted index.
using Algorithms.DynamicProgramming.Easy;
using DynamicProgramming.Easy;

Console.WriteLine("=== DynamicProgramming Algorithms ===");

// --- Easy ------------------------------------------------------------
BestTimeToBuyAndSellStock.Run(new int[] { 3, 2, 6, 5, 0, 3 });
ClimbingStairs.Run(4);
MinCostClimbingStairs.Run(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 });
MaximumRepeatingSubstring.Run("ababc", "ba");

