namespace Array.Easy;

public static class FindSubarraysWithEqualSum
{
    public static bool Run(int[] nums)
    {
        int start = 0;
        int end = 1;

        HashSet<int> visitedTotal = new();

        while (end < nums.Length)
        {
            int total = nums[start] + nums[end];
            if (visitedTotal.Contains(total))
                return true;

            visitedTotal.Add(total);
            start++;
            end++;
        }

        return false;
    }
}
