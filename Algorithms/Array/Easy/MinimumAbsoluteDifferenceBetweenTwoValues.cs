namespace Array.Easy;

public static class MinimumAbsoluteDifferenceBetweenTwoValues
{
    public static int Run(int[] nums)
    {
        List<int> numberOneIndexes = new();
        List<int> numberTwoIndexes = new();
        int minResult = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
                numberOneIndexes.Add(i);

            else if (nums[i] == 2)
                numberTwoIndexes.Add(i);
        }

        if (numberOneIndexes.Count < 1 || numberTwoIndexes.Count < 1)
            return -1;

        for (int i = 0; i < numberOneIndexes.Count; i++)
        {
            for (int j = 0; j < numberTwoIndexes.Count; j++)
            {
                int diff = Math.Abs(numberOneIndexes[i] - numberTwoIndexes[j]);
                if (diff < minResult)
                    minResult = diff;
            }
        }

        return minResult;
    }
}
