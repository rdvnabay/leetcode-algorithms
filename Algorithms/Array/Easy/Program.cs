using Algorithms.Array.Easy.Solutions;

namespace Algorithms.Array.Easy;

public static class ArrayEasyRunner
{
    public static void Run()
    {
        TwoSum.Run(new int[] { 3, 2, 4 }, 6);
        RemoveElement.Run(new int[] { 3, 2, 2, 3, 4, 3 }, 3);
        PlusOne.Run(new int[] { 9, 9, 9 });
        MergeSortedArray.Run(new int[] { 1, 4, 7, 9, 0, 0 }, 4, new int[] { 3, 8 }, 2);
        SingleNumber.Run(new int[] { 2, 2, 1 });
        MajorityElement.Run(new int[] { 2, 2, 1, 1, 1, 2, 2 });
        ContainsDuplicate.Run(new int[] { 1, 2, 3, 1 });
        ContainsDuplicateII.Run(new int[] { 5, 1, 2, 3, 5, 4, 5 }, 1);
        SummaryRanges.Run(new int[] { 0, 1, 2 });
        MoveZeroes.Run(new int[] { 0, 1, 0, 3, 12 });
        IntersectionOfTwoArrays.Run(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 });
        IntersectionOfTwoArraysII.Run(new int[] { 7, 7, 8 }, new int[] { 7, 7, 7, 8, 8, 9 });
        ThirdMaximumNumber.Run(new int[] { 4, 1, 2, 2, 5, 3, 5 });
        FindAllNumbersDisappearedInAnArray.Run(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });
        MaxConsecutiveOnes.Run(new int[] { 1, 1, 0, 1, 1, 1 });
        RelativeRanks.Run(new int[] { 5, 4, 3, 2, 1 });
        ArrayPartition.Run(new int[] { 1, 4, 3, 2 });
        CanPlaceFlowers.Run(new int[] { 0 }, 1);
        MaximumProductOfThreeNumbers.Run(new int[] { -10, -10, 5, 2 });
        MaximumAverageSubarrayI.Run(new int[] { 1, 12, -5, -6, 50, 3 }, 4);
        SetMismatch.Run(new int[] { 1, 1 });
        ImageSmoother.Run(new int[][] { [1, 1, 1], [1, 0, 1], [1, 1, 1] });
        LongestContinuousIncreasingSubsequence.Run(new int[] { 1, 3, 5, 4, 7 });
        DegreeOfAnArray.Run(new int[] { 1, 2, 2, 3, 1 });
        KidsWithTheGreatestNumberOfCandies.Run(new int[] { 2, 3, 5, 1, 3 }, 3);
        FloodFill.Run(new int[][] { [1, 1, 1], [1, 1, 0], [1, 0, 1] }, 1, 1, 2);
        LargestNumberAtLeastTwiceOfOthers.Run(new int[] { 3, 6, 1, 0 });
        ToeplitzMatrix.Run(new int[][] { [1, 2, 3, 4], [5, 1, 2, 3], [9, 5, 1, 2] });
        //ToeplitzMatrix.Run(new int[][] { [11, 74, 0, 93], [40, 11, 74, 7] });
        NumberOfLinesToWriteString.Run(new[] { 4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, "bbbcccdddaaa");
        MostCommonWord.Run("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" });
        ReshapeTheMatrix.Run(new int[][] { [1, 2], [3, 4] }, 1, 4);
    }
}