// Demo runner for 51 solution files; the README is the canonical ID-sorted index.
using Algorithms.HashTable.Easy;
using Algorithms.HashTable.Hard;
using HashTable.Easy;

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
FindMissingElements.Run(new int[] { 5, 1 });
FindTheNumberOfGoodPairsI.Run(new int[] { 1, 2, 4, 12 }, new int[] { 2, 4 }, 3);
FindCommonElementsBetweenTwoArrays.Run(new int[] { 4, 3, 2, 3, 1 }, new int[] { 2, 2, 5, 2, 3, 6 });
MaximumNumberOfWordsYouCanType.Run("leet code", "lt");
MergeTwo2DArraysBySummingValues.Run(new int[][] { [2, 4], [3, 6], [5, 5] }, new int[][] { [1, 3], [4, 3] });
FindTheDifferenceOfTwoArrays.Run(new int[] { 1, 2, 3 }, new int[] { 2, 4, 6 });
RingsAndRods.Run("B0B6G0R6R0R6G9");
CountElementsWithMaximumFrequency.Run(new int[] { 1, 2, 3, 4, 5 });
CheckIfAllCharactersHaveEqualNumberOfOccurrences.Run("abacbc");
DivideArrayIntoEqualPairs.Run(new int[] { 3, 2, 3, 2, 2, 2 });
Finding3DigitEvenNumbers.Run(new int[] { 2, 2, 8, 8, 2 });
SumOfElementsWithFrequencyDivisibleByK.Run(new int[] { 1, 2, 2, 3, 3, 3, 3, 4 }, 2);
TwoOutOfThree.Run(new int[] { 1, 1, 3, 2 }, new int[] { 2, 3 }, new int[] { 3 });
MaximumNumberOfPairsInArray.Run(new int[] { 1, 3, 2, 1, 3, 2, 2 });
FindLuckyIntegerInAnArray.Run(new int[] { 1, 2, 2, 3, 3, 3 });
FirstLetterToAppearTwice.Run("eesll");
KeepMultiplyingFoundValuesByTwo.Run(new int[] { 5, 3, 6, 1, 12 }, 3);
FindCommonCharacters.Run(new string[] { "bella", "label", "roller" });
MakeArrayZeroBySubtractingEqualAmounts.Run(new int[] { 1, 5, 0, 3, 5 });
CountPairsOfSimilarStrings.Run(new string[] { "aba", "aabb", "abcd", "bac", "aabc" });
CountCommonWordsWithOneOccurrence.Run(new string[] { "leetcode", "is", "leetcode", "is", "amazing", "and", "fantastic" }, new string[] { "leetcode", "is", "leetcode", "is", "fantastic" });
PointsThatIntersectWithCars.Run(new List<IList<int>>
{
    new List<int> { 3, 6 },
    new List<int> { 1, 5 },
    new List<int> { 4, 7 }
});
NumberOfUnequalTripletsInArray.Run(new int[] { 4, 4, 2, 4, 3 });
CheckIfNumberHasEqualDigitCountAndDigitValue.Run("030");
ToggleLightBulbs.Run(new List<int>() { 10, 30, 20, 10 });
MinimumNumberOfOperationsToMakeElementsInArrayDistinct.Run(new int[] { 1, 2, 3, 4, 2, 3, 3, 5, 7 });
FindResultantArrayAfterRemovingAnagrams.Run(new string[] { "abba", "baba", "bbaa", "cd", "cd" });
IntersectionOfMultipleArrays.Run(new int[][] { [3, 1, 2, 4, 5], [1, 2, 3, 4], [3, 4, 5, 6] });
FindTheLeastFrequentDigit.Run(723344511);
FirstUniqueEvenElement.Run(new int[] { 4, 4 });
SmallestMissingMultipleOfK.Run(new int[] { 8, 2, 3, 4, 6 }, 2);
CountSpecialQuadruplets.Run(new int[] { 1, 1, 1, 3, 5 });
OddStringDifference.Run(new string[] { "adc", "wzy", "abc" });
RestoreFinishingOrder.Run(new int[] { 3, 1, 2, 5, 4 }, new int[] { 1, 3, 4 });
PermutationDifferenceBetweenTwoStrings.Run("abc", "bac");
SortThePeople.Run(["Mary", "John", "Emma"], [180, 165, 170]);
CountPairsThatFormACompleteDayI.Run([12, 12, 30, 24, 24]);
LongestSubsequenceWithLimitedSum.Run([2, 3, 4, 5], [1]);
RemoveDigitFromNumberToMaximizeResult.Run("123", '3');
MinimumMovesToConvertString.Run("XXOX");


// --- Hard ------------------------------------------------------------


