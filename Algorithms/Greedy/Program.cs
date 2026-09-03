// Demo runner for 20 solution files; the README is the canonical ID-sorted index.
using Algorithms.Greedy.Easy;
using Greedy.Easy;
using Greedy.Medium;

Console.WriteLine("=== Greedy Algorithms ===");

// --- Easy ------------------------------------------------------------
AssignCookies.Run(new int[] { 1, 2, 3 }, new int[] { 1, 1 });
JumpGame.Run(new int[] { 3, 2, 1, 0, 4 });
TeemoAttacking.Run(new int[] { 1, 3, 8 }, 4);
MinimumOperationsToMakeTheArrayIncreasing.Run(new int[] { 1, 5, 2, 4, 1 });
LexicographicallySmallestPalindrome.Run("seven");
MaximumSumWithExactlyKElements.Run(new int[] { 5, 5 }, 2);
AppleRedistributionIntoBoxes.Run(new int[] { 1, 3, 2 }, new int[] { 4, 3, 1, 5, 2 });
MaximizeSumOfAtMostKDistinctElements.Run(new int[] { 84, 93, 100, 77, 90 }, 3);
MaximumDifferenceByRemappingADigit.Run(11891);
MaximumUnitsOnATruck.Run(new int[][] { [1, 3], [2, 2], [3, 1] }, 4);
MinimumSubsequenceInNonIncreasingOrder.Run(new int[] { 4, 3, 10, 9, 8 });
BuyTwoChocolates.Run(new int[] { 1, 2, 2 }, 3);
MinimumNumberOfOperationsToConvertTime.Run("02:30", "04:35");
LargestIntegerWithGivenDigitSum.Run(2, 9);
MinimumMovesToConvertString.Run("XXOX");
MinimumAmountOfTimeToFillCups.Run(new int[] { 1, 4, 2 });
MinimumTimeToTypeWordUsingSpecialTypewriter.Run("bza");
LatestTimeByReplacingHiddenDigits.Run("0?:3?");


// --- Medium ------------------------------------------------------------
GroupThePeopleGivenTheGroupSizeTheyBelongTo.Run([3, 3, 3, 3, 3, 1, 3]);
PartitionLabels.Run("ababcbacadefegdehijhklij");



