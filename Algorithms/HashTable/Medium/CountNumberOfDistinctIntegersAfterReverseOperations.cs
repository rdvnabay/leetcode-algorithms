namespace HashTable.Medium;

public static class CountNumberOfDistinctIntegersAfterReverseOperations
{
    public static int Run(int[] nums)
    {
        HashSet<int> result = new(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            int pow = num.ToString().Length - 1;
            int reverseNum = 0;

            while (num > 0)
            {
                int remainder = num % 10;
                reverseNum = reverseNum * 10 + remainder;
                pow--;
                num /= 10;
            }

            result.Add(reverseNum);
        }

        return result.Count;
    }
}
