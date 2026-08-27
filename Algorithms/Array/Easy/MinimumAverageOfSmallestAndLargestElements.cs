/**
 * @id         3194
 * @title      Minimum Average of Smallest and Largest Elements
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/minimum-average-of-smallest-and-largest-elements/
 */
using System.Net;

namespace Array.Easy;

public static class MinimumAverageOfSmallestAndLargestElements
{
    //7,8,3,4,15,13,4,1
    public static double Run(int[] nums)
    {
        System.Array.Sort(nums);

        int left = 0;
        int right = nums.Length - 1;
        double minAverage = double.MaxValue;

        while (left < right)
        {
            double value = (double)(nums[left] + nums[right]) / 2;
            if (value < minAverage)
                minAverage = value;

            left++;
            right--;
        }

        return minAverage;
    }
}


