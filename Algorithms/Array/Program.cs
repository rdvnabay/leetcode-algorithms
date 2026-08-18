using Algorithms.Array.Easy;
using Algorithms.Array.Medium;
using Array.Easy;
using Array.Medium;

Console.WriteLine("=== Array Algorithms ===");

// --- Easy ------------------------------------------------------------
_1BitAnd2BitCharacters.Run(new int[] { 1, 1, 1, 0 });
ArrayPartition.Run(new int[] { 1, 4, 3, 2 });
CanPlaceFlowers.Run(new int[] { 0 }, 1);
ContainsDuplicate.Run(new int[] { 1, 2, 3, 1 });
DecompressRunLengthEncodedList.Solution2(new int[] { 1, 2, 3, 4 });
DegreeOfAnArray.Run(new int[] { 1, 2, 2, 3, 1 });
DeleteColumnsToMakeSorted.Run(new string[] { "cba", "daf", "ghi" });
DuplicateZeros.Run(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 });
FindNUniqueIntegersSumUpToZero.Run(6);
FloodFill.Run(new int[][] { [1, 1, 1], [1, 1, 0], [1, 0, 1] }, 1, 1, 2);
HeightChecker.Run(new int[] { 1, 1, 4, 2, 1, 3 });
KidsWithTheGreatestNumberOfCandies.Run(new int[] { 2, 3, 5, 1, 3 }, 3);
LargestNumberAtLeastTwiceOfOthers.Run(new int[] { 3, 6, 1, 0 });
LemonadeChange.Run(new int[] { 5, 5, 10, 5, 20, 5, 5, 5, 5, 5, 20, 5, 10, 5, 5, 5, 5, 20, 20, 5 });
MajorityElement.Run(new int[] { 2, 2, 1, 1, 1, 2, 2 });
MaxConsecutiveOnes.Run(new int[] { 1, 1, 0, 1, 1, 1 });
MaximizeSumOfArrayAfterKNegations.Run(new int[] { 5, 6, 9, -3, 3 }, 2);
MaximumProductOfThreeNumbers.Run(new int[] { -10, -10, 5, 2 });
MergeSortedArray.Run(new int[] { 1, 4, 7, 9, 0, 0 }, 4, new int[] { 3, 8 }, 2);
MonotonicArray.Run(new int[] { 1, 2, 5, 3, 3 });
MostCommonWord.Run("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" });
MoveZeroes.Run(new int[] { 0, 1, 0, 3, 12 });
NumberOfLinesToWriteString.Run(new[] { 4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, "bbbcccdddaaa");
PlusOne.Run(new int[] { 9, 9, 9 });
RankTransformOfAnArray.Run(new int[] { 40, 10, 20, 30, 10, 40 });
RelativeRanks.Run(new int[] { 5, 4, 3, 2, 1 });
RelativeSortArray.Run(new int[] { 33, 22, 48, 4, 39, 36, 41, 47, 15, 45 }, new int[] { 22, 33, 48, 4 });
RemoveElement.Run(new int[] { 3, 2, 2, 3, 4, 3 }, 3);
ReshapeTheMatrix.Run(new int[][] { [1, 2], [3, 4] }, 1, 4);
SetMismatch.Run(new int[] { 1, 1 });
SingleNumber.Run(new int[] { 2, 2, 1 });
SortArrayByParity.Run(new int[] { 3, 1, 2, 4 });
SquaresOfASortedArray.Run(new int[] { -4, -2, 0, 3, 5 });
SummaryRanges.Run(new int[] { 0, 1, 2 });
ThirdMaximumNumber.Run(new int[] { 4, 1, 2, 2, 5, 3, 5 });
ToeplitzMatrix.Run(new int[][] { [1, 2, 3, 4], [5, 1, 2, 3], [9, 5, 1, 2] });
TransposeMatrix.Run(new int[][] { [1, 2, 3], [4, 5, 6] });
TwoSum.Run(new int[] { 3, 2, 4 }, 6);
UniqueNumberOfOccurrences.Run(new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 });
ValidMountainArray.Run(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
WordBreak.Run("catsandog", new List<string>() { "cats", "dog", "sand", "and", "cat" });
ConcatenateArrayWithReverse.Run(new int[] { 1, 2, 3 });
BuildArrayFromPermutation.Run(new int[] { 0, 2, 1, 5, 3, 4 });
ComputeAlternatingSum.Run(new int[] { 1, 3, 5, 7 });
ConcatenationOfArray.Run(new int[] { 1, 3, 2, 1 });
TransformArrayByParity.Run(new int[] { 4, 3, 2, 1 });
LeftAndRightSumDifferences.Run(new int[] { 10, 4, 8, 3 });
RichestCustomerWealth.Run(new int[][] { [1, 5], [7, 3], [3, 5] });
ShuffleTheArray.Run(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4);
WeightedWordMapping.Run(new string[] { "abcd", "def", "xyz" }, new int[] { 5, 3, 12, 14, 1, 2, 3, 2, 10, 6, 6, 9, 7, 8, 7, 10, 8, 9, 6, 9, 9, 8, 3, 7, 7, 2 });
NumberOfEmployeesWhoMetTheTarget.Run(new int[] { 0, 1, 2, 3, 4 }, 2);
CountPairsWhoseSumIsLessThanTarget.Run(new List<int>() { -6, 2, 5, -2, -7, -1, 3 }, -2);
FindIndicesOfStableMountains.Run(new int[] { 1, 2, 3, 4, 5 }, 2);
RunningSumOf1dArray.Run(new int[] { 1, 2, 3, 4 });
MinimumNumberOfMovesToSeatEveryone.Run(new int[] { 3, 1, 5 }, new int[] { 2, 7, 4 });
CountGoodTriplets.Run(new int[] { 3, 0, 1, 1, 9, 7 }, 7, 2, 3);


// --- Medium ------------------------------------------------------------
_3Sum.Run(new int[] { -1, 0, 1, 2, -1, -4 });
NextPermutation.Run(new int[] { 3, 2, 1 });
ProductOfArrayExceptSelf.Run(new int[] { 1, 2, 3, 4 });
SetMatrixZeroes.Run(new int[][] { [1, 1, 1], [1, 0, 0], [1, 1, 1] });
SortColors.Run(new int[] { 2, 0, 2, 1, 1, 0 });
Subsets.Run(new int[] { 1, 2, 3 });
FindThePrefixCommonArrayOfTwoArrays.Run(new int[] { 2, 3, 1 }, new int[] { 3, 1, 2 });
NumberOfLaserBeamsInABank.Run(new string[] { "011001", "000000", "010100", "001000" });
MaximumNumberOfCoinsYouCanGet.Run(new int[] { 9, 8, 7, 6, 5, 1, 2, 3, 4 });
RearrangeArrayElementsBySign.Run(new int[] { 3, 1, -2, -5, 2, -4 });
ArithmeticSubarrays.Run(new int[] { 4, 6, 5, 9, 3, 7 }, new int[] { 0, 0, 2 }, new int[] { 2, 3, 5 });
PartitionArrayAccordingToGivenPivot.Run(new int[] { 9, 12, 5, 10, 14, 3, 10 }, 10);
MinimumNumberOfOperationsToMoveAllBallsToEachBox.Run("001011");

SubrectangleQueries subrectangleQueries = new([[1, 2, 1], [4, 3, 4], [3, 2, 1], [1, 1, 1]]);
subrectangleQueries.UpdateSubrectangle(0, 0, 3, 2, 5);
subrectangleQueries.GetValue(0, 2);

CountDigitAppearances.Run(new int[] { 12, 54, 32, 22 }, 2);
ConvertAnArrayIntoA2DArrayWithConditions.Run(new int[] { 1, 3, 4, 1, 2, 3, 1 });
SortTheStudentsByTheirKthScore.Run(new int[][] { [10, 6, 9, 1], [7, 5, 11, 2], [4, 8, 3, 15] }, 2);
MinimumAmountOfTimeToCollectGarbage.Run(new string[] { "G", "P", "GP", "GG" }, new int[] { 2, 3, 4 });
QueriesOnAPermutationWithKey.Run(new int[] { 3, 1, 2, 1 }, 5);
SortMatrixByDiagonals.Run(new int[][] { [1, 7, 3], [9, 8, 2], [4, 5, 6] });
DifferenceBetweenOnesAndZerosInRowAndColumn.Run(new int[][] { [0, 1, 1], [1, 0, 1], [0, 0, 1] });

