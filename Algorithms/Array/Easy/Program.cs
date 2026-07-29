using Algorithms.Array.Easy.Solutions;

namespace Algorithms.Array.Easy;

public static class ArrayEasyRunner
{
    public static void Run()
    {
        // 1: Two Sum
        TwoSum.Run(new int[] { 3, 2, 4 }, 6);
        // 27: Remove Element
        RemoveElement.Run(new int[] { 3, 2, 2, 3, 4, 3 }, 3);
        // 35: Search Insert Position — moved to BinarySearch
        // 66: Plus One
        PlusOne.Run(new int[] { 9, 9, 9 });
        // 88: Merge Sorted Array
        MergeSortedArray.Run(new int[] { 1, 4, 7, 9, 0, 0 }, 4, new int[] { 3, 8 }, 2);
        // 121: Best Time to Buy — moved to DynamicProgramming
        // 136: Single Number
        SingleNumber.Run(new int[] { 2, 2, 1 });
        // 169: Majority Element
        MajorityElement.Run(new int[] { 2, 2, 1, 1, 1, 2, 2 });
        // 217: Contains Duplicate
        ContainsDuplicate.Run(new int[] { 1, 2, 3, 1 });
        // 219: Contains Duplicate II
        ContainsDuplicateII.Run(new int[] { 5, 1, 2, 3, 5, 4, 5 }, 1);
        // 228: Summary Ranges
        SummaryRanges.Run(new int[] { 0, 1, 2 });
        // 238: (commented out — not yet solved)
        // 268: Missing Number — moved to Math
        // 283: Move Zeroes
        MoveZeroes.Run(new int[] { 0, 1, 0, 3, 12 });
        // 349: Intersection of Two Arrays
        IntersectionOfTwoArrays.Run(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 });
        // 350: Intersection of Two Arrays II
        IntersectionOfTwoArraysII.Run(new int[] { 7, 7, 8 }, new int[] { 7, 7, 7, 8, 8, 9 });
        // 414: Third Maximum Number
        ThirdMaximumNumber.Run(new int[] { 4, 1, 2, 2, 5, 3, 5 });
        // 448: Find All Numbers Disappeared in an Array
        FindAllNumbersDisappearedInAnArray.Run(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });
        // 485: Max Consecutive Ones
        MaxConsecutiveOnes.Run(new int[] { 1, 1, 0, 1, 1, 1 });
        // 506: Relative Ranks
        RelativeRanks.Run(new int[] { 5, 4, 3, 2, 1 });
        // 561: Array Partition
        ArrayPartition.Run(new int[] { 1, 4, 3, 2 });
        // 605: Can Place Flowers
        CanPlaceFlowers.Run(new int[] { 0 }, 1);
        // 628: Maximum Product of Three Numbers
        MaximumProductOfThreeNumbers.Run(new int[] { -10, -10, 5, 2 });
        // 643: Maximum Average Subarray I
        MaximumAverageSubarrayI.Run(new int[] { 1, 12, -5, -6, 50, 3 }, 4);
        // 645: Set Mismatch
        SetMismatch.Run(new int[] { 1, 1 });
        // 661: Image Smoother
        ImageSmoother.Run(new int[][] { [1,1,1], [1,0,1], [1,1,1] });
        // 674: Longest Continuous Increasing Subsequence
        LongestContinuousIncreasingSubsequence.Run(new int[] { 1, 3, 5, 4, 7 });
        // 697: Degree of an Array
        DegreeOfAnArray.Run(new int[] { 1, 2, 2, 3, 1 });
        // 1431: Kids With the Greatest Number of Candies
        KidsWithTheGreatestNumberOfCandies.Run(new int[] { 2, 3, 5, 1, 3 }, 3);
    }
}