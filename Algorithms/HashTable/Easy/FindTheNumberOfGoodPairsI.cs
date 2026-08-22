namespace HashTable.Easy;

public static class FindTheNumberOfGoodPairsI
{
    //Input: nums1 = [1,2,4,12], nums2 = [2,4], k = 3

    //Output: 2

    //Explanation:

    //The 2 good pairs are(3, 0) and(3, 1).
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
