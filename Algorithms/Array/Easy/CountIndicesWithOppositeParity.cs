namespace Array.Easy;

public static class CountIndicesWithOppositeParity
{
    public static int[] Run(int[] nums)
    {
        int oddCount = 0;
        int evenCount = 0;
        int[] result = new int[nums.Length];

        foreach (int num in nums)
        {
            if (num % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                evenCount--;
                result[i] = oddCount;
            }
            else
            {
                oddCount--;
                result[i] = evenCount;
            }
        }

        return result;
    }
}
