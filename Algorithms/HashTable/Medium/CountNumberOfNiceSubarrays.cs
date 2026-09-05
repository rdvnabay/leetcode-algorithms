namespace HashTable.Medium;

public static class CountNumberOfNiceSubarrays
{
    public static int Run(int[] nums, int k)
    {
        //2,2,2,1,2,2,1,2,2,2  2
        int subArrayCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int oddCount = nums[i] % 2 == 1 ? 1 : 0;

            if (oddCount == k)
                subArrayCount++;

            for (int j = i + 1; j < nums.Length; j++)
            {
                bool isOdd = nums[j] % 2 == 1;
                if (isOdd)
                    oddCount++;

                if (oddCount == k)
                    subArrayCount++;

                else if (oddCount > k)
                    break;
            }
        }

        return subArrayCount;
    }
}
