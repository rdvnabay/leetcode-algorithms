/**
 * @id         496
 * @title      Next Greater Element I
 * @topic      stack
 * @difficulty Easy
 * @link       https://leetcode.com/problems/next-greater-element-i/
 */
namespace Algorithms.Stack.Easy;

public class NextGreaterElementI
{
    public static int[] Run(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> dict = new();

        for (int i = 0; i < nums2.Length; i++)
            dict.Add(nums2[i], i);

        for (int i = 0; i < nums1.Length; i++)
        {
            bool nextGreater = false;
            int currentIndex = dict[nums1[i]];

            for (int j = currentIndex; j < nums2.Length - 1; j++)
            {
                int current = nums1[i];
                int right = nums2[j + 1];

                if (current < right)
                {
                    nums1[i] = right;
                    nextGreater = true;
                    break;
                }
            }
            if (!nextGreater)
                nums1[i] = -1;
        }

        return nums1;
    }
}


