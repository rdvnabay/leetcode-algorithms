namespace Array.Easy;

public static class UniqueMiddleElement
{
    public static bool Run(int[] nums)
    {
        int middleIndex = (nums.Length / 2) + 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i == middleIndex)
                continue;

            if (nums[i] == nums[middleIndex])
                return false;
        }

        return true;
    }
}
