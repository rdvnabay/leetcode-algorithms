namespace Algorithms.Array.Easy.Solutions;

public static class ThirdMaximumNumber
{
    public static int Run(int[] nums)
    {
        HashSet<int> result = new(nums);

        if (result.Count < 3)
            return result.Max();
        else
        {
            result.Remove(result.Max());
            result.Remove(result.Max());
            return result.Max();
        }
    }
}
