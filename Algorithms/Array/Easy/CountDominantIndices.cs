namespace Array.Easy;

public static class CountDominantIndices
{
    public static int Run(int[] nums)
    {
        int dominantCount = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            int total = 0;
            for (int j = i + 1; j < nums.Length; j++)
            {
                total += nums[j];
            }

            var average = total / (nums.Length - (i + 1));
            if (nums[i] > average)
            {
                dominantCount++;
            }
        }

        return dominantCount;
    }
}
