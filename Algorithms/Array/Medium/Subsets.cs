namespace Array.Medium;

public static class Subsets
{
    public static IList<IList<int>> Run(int[] nums)
    {
        List<List<int>> result = new();

        var subCount = System.Math.Pow(2, nums.Length);


        for (int i = 0; i < subCount; i++)
        {
            //var test = Convert.ToString(nums[i], 2).PadLeft(nums.Length, '0');
            //var a = (nums[i] & (1 << 0)) != 0;
            //var b = (nums[i] & (1 << 1)) != 0;
            //var c = (nums[i] & (1 << 2)) != 0;
        }
        return null;
    }
}
