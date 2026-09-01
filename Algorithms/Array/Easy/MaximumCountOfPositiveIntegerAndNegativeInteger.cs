namespace Array.Easy;

public static class MaximumCountOfPositiveIntegerAndNegativeInteger
{
    public static int Run(int[] nums)
    {
        int zerosCount = 0;
        int negativeCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];

            if (num < 0)
                negativeCount++;
            else if (num == 0)
                zerosCount++;
            else
                break;
        }

        int positiveCount = nums.Length - negativeCount - zerosCount;

        return Math.Max(positiveCount, negativeCount);
    }
}
