namespace HashTable.Easy;

public static class TwoOutOfThree
{
    //Input: nums1 = [1,1,3,2], nums2 = [2,3], nums3 = [3]
    //Output: [3, 2]
    public static IList<int> Run(int[] nums1, int[] nums2, int[] nums3)
    {
        HashSet<int> setNums1 = new(nums1);
        HashSet<int> setNums2 = new(nums2);
        HashSet<int> setNums3 = new(nums3);
        Dictionary<int, int> dict = new();

        foreach (var num1 in setNums1)
            dict[num1] = dict.GetValueOrDefault(num1, 0) + 1;

        foreach (var num2 in setNums2)
            dict[num2] = dict.GetValueOrDefault(num2, 0) + 1;

        foreach (var num3 in setNums3)
            dict[num3] = dict.GetValueOrDefault(num3, 0) + 1;

        return dict.Where(x => x.Value > 1).Select(x => x.Key).ToArray();
    }
}
