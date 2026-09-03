/**
 * @id         3131
 * @title      Find the Integer Added to Array I
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-the-integer-added-to-array-i/
 */
namespace Array.Easy;

public static class FindTheIntegerAddedToArrayI
{
    public static int Run(int[] nums1, int[] nums2)
    {
        System.Array.Sort(nums1);
        System.Array.Sort(nums2);

        return nums2[0] - nums1[0];
    }
}
