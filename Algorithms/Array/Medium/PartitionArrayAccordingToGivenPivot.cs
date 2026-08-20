/**
 * @id         2161
 * @title      Partition Array According to Given Pivot
 * @topic      array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/partition-array-according-to-given-pivot/
 */
namespace Array.Medium;

public static class PartitionArrayAccordingToGivenPivot
{
    public static int[] Run(int[] nums, int pivot)
    {
        List<int> left = new();
        List<int> mid = new();
        List<int> right = new();
        List<int> result = new();

        foreach (int num in nums)
        {
            if (num < pivot)
                left.Add(num);
            else if (num > pivot)
                right.Add(num);
            else
                mid.Add(num);
        }

        foreach (var num in left)
            result.Add(num);

        foreach (var num in mid)
            result.Add(num);

        foreach (var num in right)
            result.Add(num);

        return result.ToArray();
    }
}


