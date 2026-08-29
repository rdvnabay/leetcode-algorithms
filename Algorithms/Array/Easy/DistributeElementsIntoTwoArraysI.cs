namespace Array.Easy;

public static class DistributeElementsIntoTwoArraysI
{
    public static int[] Run(int[] nums)
    {
        List<int> arr1 = new() { nums[0] };
        List<int> arr2 = new() { nums[1] };

        for (int i = 2; i < nums.Length; i++)
        {
            if (arr1[^1] > arr2[^1])
                arr1.Add(nums[i]);
            else
                arr2.Add(nums[i]);
        }

        return [.. arr1, .. arr2];
    }
}
