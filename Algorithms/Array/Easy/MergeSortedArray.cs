/**
 * @id         88
 * @title      Merge Sorted Array
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/merge-sorted-array/
 */
namespace Algorithms.Array.Easy;

public class MergeSortedArray
{
    public static void Run(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = 0; i < nums2.Length; i++)
        {
            for (int j = 0; j < nums1.Length; j++)
            {
                if (nums2[i] <= nums1[j])
                {
                    var temp = nums1[j];
                    nums1[j] = nums2[i];

                    for (int k = j + 1; k < nums1.Length; k++)
                    {
                        var currentTemp = nums1[k];
                        nums1[k] = temp;
                        temp = currentTemp;
                    }
                    break;
                }
                else if (j - i == m && nums1[j] == 0)
                {
                    nums1[j] = nums2[i];
                    break;
                }
            }
        }
    }
}

