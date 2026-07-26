namespace Algorithms.Solutions.Easy;

public class IntersectionOfTwoArraysII
{
    public static int[] Run(int[] nums1, int[] nums2)
    {
        List<int> result = new();
        Dictionary<int, int> nums1Dict = new();
        Dictionary<int, int> nums2Dict = new();

        foreach (var num in nums1)
        {
            if (!nums1Dict.TryGetValue(num, out _))
                nums1Dict[num] = 1;
            else
                nums1Dict[num]++;
        }

        foreach (var num in nums2)
        {
            if (!nums2Dict.TryGetValue(num, out _))
                nums2Dict[num] = 1;
            else
                nums2Dict[num]++;
        }

        foreach (var item in nums1Dict)
        {
            if( nums2Dict.TryGetValue(item.Key, out int value))
            {
                int minCount = Math.Min(item.Value, value);
                result.AddRange(Enumerable.Repeat(item.Key, minCount));
            }
        }

        return result.ToArray();
    }
}
