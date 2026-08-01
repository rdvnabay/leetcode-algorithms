namespace Algorithms.Array.Easy;

public class IntersectionOfTwoArrays
{
    public static int[] Run(int[] nums1, int[] nums2)
    {
        HashSet<int> nums1Set = new(nums1);
        HashSet<int> result = new();

        foreach (int num in nums2)
        {
            if (nums1Set.Contains(num))
                result.Add(num);
        }

        return result.ToArray();
    }


    //Alternative solutions
     static int[] Solution2(int[] nums1, int[] nums2)
    {
        List<int> result = new();

        for (int i = 0; i < nums2.Length; i++)
        {
            if (result.Contains(nums2[i]))
                continue;

            for (int j = 0; j < nums1.Length; j++)
            {
                if (nums2[i] == nums1[j])
                {
                    result.Add(nums2[i]);
                    break;
                }
            }
        }

        return result.ToArray();
    }
}
