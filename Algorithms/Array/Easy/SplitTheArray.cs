namespace Array.Easy;

public static class SplitTheArray
{
    //1,1,2,2,3,4
    public static bool Run(int[] nums)
    {
        HashSet<int> nums1 = new HashSet<int>();
        HashSet<int> nums2 = new HashSet<int>();
        int length = nums.Length / 2;

        for (int i = 0; i < nums.Length; i++)
        {
            bool addResult = false;

            if (nums1.Count < length)
                addResult = nums1.Add(nums[i]);

            if (!addResult)
                nums2.Add(nums[i]);
        }

        return nums1.Except(nums2).Count() > 0;
    }
}