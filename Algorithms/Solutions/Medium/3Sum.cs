namespace Algorithms.Solutions.Medium;

public static class _3Sum
{
    public static IList<IList<int>> Run(int[] nums)
    {
        List<List<int>> result = new();
        List<string> concatenateNumbers = new();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        var output = new List<int> { nums[i], nums[j], nums[k] };
                        output.Sort();

                        if (!result.Any(x => x[0] == output[0] && x[1] == output[1] && x[2] == output[2]))
                            result.Add(output);
                    }

                }
            }
        }

        return result.ToArray();
    }
}
