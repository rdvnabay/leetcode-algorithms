// Demo runner for 1 indexed solution files. Canonical ordering: LeetCode problem ID.
using Algorithms.TwoPointers.Easy;
using TwoPointers.Easy;

Console.WriteLine("=== TwoPointers Algorithms ===");

// --- Easy ------------------------------------------------------------
IsSubsequence.Run("", "");
ReversePrefixOfWord.Run("abcdefd", 'd');
NumberOfArithmeticTriplets.Run(new int[] { 0, 1, 4, 6, 7, 10 }, 3);
LimitOccurrencesInSortedArray.Run(new int[] { 1, 1, 1, 2, 2, 3 }, 2);
ApplyOperationsToAnArray.Run(new int[] { 1, 2, 2, 1, 1, 0 });
FindTheArrayConcatenationValue.Run(new int[] { 5, 14, 13, 8, 12 });


