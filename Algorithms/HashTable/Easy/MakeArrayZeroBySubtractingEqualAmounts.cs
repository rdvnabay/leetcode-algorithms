namespace HashTable.Easy;

public static class MakeArrayZeroBySubtractingEqualAmounts
{
    public static int Run(int[] nums)
    {
        int counter = 1;
        int zeroCount = 0;

        while (zeroCount != nums.Length)
        {
            int minPositiveNumber = int.MaxValue;

            foreach (var num in nums)
            {
                if (num > 0 && num < minPositiveNumber)
                    minPositiveNumber = num;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    nums[i] = nums[i] - minPositiveNumber;

                if (nums[i] == 0)
                    zeroCount++;
            }
            counter++;
        }


        return counter;
    }
}
