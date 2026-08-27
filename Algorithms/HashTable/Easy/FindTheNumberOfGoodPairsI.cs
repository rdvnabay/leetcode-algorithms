/**
 * @id         3162
 * @title      Find the Number of Good Pairs I
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-the-number-of-good-pairs-i/
 */
namespace HashTable.Easy;

public static class FindTheNumberOfGoodPairsI
{
    public static int Run(int[] nums1, int[] nums2, int k)
    {
        int total = 0;

        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < nums2.Length; j++)
            {
                if (nums1[i] % (nums2[j] * k) == 0)
                    total++;
            }
        }

        return total;
    }
}
