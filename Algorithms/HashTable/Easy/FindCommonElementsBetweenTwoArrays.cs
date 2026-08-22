namespace HashTable.Easy;

public static class FindCommonElementsBetweenTwoArrays
{
    //Input: nums1 = [4,3,2,3,1], nums2 = [2,2,5,2,3,6]

    //Output: [3, 4]
    public static int[] Run(int[] nums1, int[] nums2)
    {
        int counter1 = 0;
        int counter2 = 0;

        HashSet<int> setNums1 = new(nums1);
        HashSet<int> setNums2 = new(nums2);

        foreach (var num1 in nums1)
        {
            if (setNums2.Contains(num1))
                counter1++;
        }

        foreach (var num2 in nums2)
        {
            if (setNums1.Contains(num2))
                counter2++;
        }

        return [counter1, counter2];
    }
}
