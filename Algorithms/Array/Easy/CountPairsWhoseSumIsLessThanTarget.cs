namespace Array.Easy;

public static class CountPairsWhoseSumIsLessThanTarget
{
    //-6,2,5,-2,-7,-1,3    -2
    public static int Run(IList<int> nums, int target)
    {
        int counter = 0;

        for (int i = 0; i < nums.Count - 1; i++)
        {
            for (int j = i + 1; j < nums.Count; j++)
            {
                if (nums[i] + nums[j] < target)
                    counter++;
            }
        }

        return counter;
    }
}
