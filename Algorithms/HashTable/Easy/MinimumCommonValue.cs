namespace HashTable.Easy;

public static class MinimumCommonValue
{
    public static int Run(int[] nums1, int[] nums2)
    {
        HashSet<int> setNums2 = new(nums2);

        foreach (var num in nums1)
        {
            if (setNums2.Contains(num))
                return num;
        }

        return -1;
    }
}
