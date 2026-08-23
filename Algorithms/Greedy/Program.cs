// Demo runner for 3 indexed solution files. Canonical ordering: LeetCode problem ID.
using Algorithms.Greedy.Easy;
using Greedy.Easy;

Console.WriteLine("=== Greedy Algorithms ===");

// --- Easy ------------------------------------------------------------
AssignCookies.Run(new int[] { 1, 2, 3 }, new int[] { 1, 1 });
JumpGame.Run(new int[] { 3, 2, 1, 0, 4 });
TeemoAttacking.Run(new int[] { 1, 3, 8 }, 4);
MinimumOperationsToMakeTheArrayIncreasing.Run(new int[] { 1, 5, 2, 4, 1 });
LexicographicallySmallestPalindrome.Run("seven");
MaximumSumWithExactlyKElements.Run(new int[] { 5, 5 }, 2);
AppleRedistributionIntoBoxes.Run(new int[] { 1, 3, 2 }, new int[] { 4, 3, 1, 5, 2 });


