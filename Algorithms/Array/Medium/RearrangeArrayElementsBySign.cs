namespace Array.Medium;

public static class RearrangeArrayElementsBySign
{
    public static int[] Run(int[] nums)
    {
        int[] positiveNumbers = new int[nums.Length / 2];
        int[] negativeNumbers = new int[nums.Length / 2];
        int[] result = new int[nums.Length];

        int pIndex = 0;
        int nIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= 0)
            {
                positiveNumbers[pIndex] = nums[i];
                pIndex++;
            }
            else
            {
                negativeNumbers[nIndex] = nums[i];
                nIndex++;
            }
        }

        for (int i = 0; i < nums.Length / 2; i++)
        {
            result[i * 2] = positiveNumbers[i];
            result[i * 2 + 1] = negativeNumbers[i];
        }

        return result;
    }
}
