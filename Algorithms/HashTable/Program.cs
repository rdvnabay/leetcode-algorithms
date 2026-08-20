// Demo runner for 18 indexed solution files. Canonical ordering: LeetCode problem ID.
using Algorithms.HashTable.Easy;
using Algorithms.HashTable.Hard;

Console.WriteLine("=== HashTable Algorithms ===");

// --- Easy ------------------------------------------------------------
DistributeCandies.Run(new int[] { 6, 6, 6, 6 });
FairCandySwap.Run(new int[] { 1, 2, 5 }, new int[] { 2, 4 });
FindTheDifference.Run("aab", "aabb");
FindWordsThatCanBeFormedByCharacters.Run(new string[] { "cat", "bt", "hat", "tree" }, "atach");
HowManyNumbersAreSmallerThanTheCurrentNumber.Run(new int[] { 8, 1, 2, 2, 3 });
LongestHarmoniousSubsequence.Run(new int[] { 1, 3, 2, 2, 5, 2, 3, 7 });
LongestPalindrome.Run("ccc");
RankTransformOfAnArray.Run(new int[] { 37, 12, 28, 9, 100, 56, 80, 5, 12 });
SumOfUniqueElements.Run(new int[] { 1, 2, 3, 2 });
UncommonWordsFromTwoSentences.Run("this apple is sweet", "this apple is sour");
UniqueNumberOfOccurrences.Run(new int[] { 1, 2, 2, 1, 1, 3, 3 });
VerifyingAnAlienDictionary.Run(new string[] { "hello", "leetcode" }, "hlabcdefgijkmnopqrstuvwxyz");

// --- Hard ------------------------------------------------------------


