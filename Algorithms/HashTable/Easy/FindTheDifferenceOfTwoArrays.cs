namespace HashTable.Easy;

public static class FindTheDifferenceOfTwoArrays
{
    public static IList<IList<int>> Run(int[] nums1, int[] nums2)
    {
        List<IList<int>> result = new();
        HashSet<int> setNums1 = new(nums1);
        HashSet<int> setNums2 = new(nums2);

        List<int> list1 = new();
        List<int> list2 = new();

        foreach(int num1 in setNums1)
        {
            if (!setNums2.Contains(num1))
                list1.Add(num1);
        }

        foreach (int num2 in setNums2)
        {
            if (!setNums1.Contains(num2))
                list2.Add(num2);
        }

        result.Add(list1);
        result.Add(list2);

        return result;
    }
}
