namespace Algorithms.Array.Medium;

public static class _3Sum
{
    public static IList<IList<int>> Run(int[] nums)
    {
        List<List<int>> result = new();
        List<string> concatenateNumbers = new();
        List<string> s = new();

        List<HashSet<int>> hashset = new();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    s.Add($"i:{i} j:{j} k:{k}");
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        var output = new HashSet<int> { nums[i], nums[j], nums[k] };
                        var test = output.Order().ToHashSet();
                        //output.order();

                        hashset.Add(test);
                    }
                    //if (nums[i] + nums[j] + nums[k] == 0)
                    //{
                    //    var output = new List<int> { nums[i], nums[j], nums[k] };
                    //    output.Sort();

                    //    if (!result.Any(x => x[0] == output[0] && x[1] == output[1] && x[2] == output[2]))
                    //        result.Add(output);

                    //    break;
                    //}
                }
            }
        }

        return result.ToArray();
    }


    public static IList<IList<int>> Run3(int[] nums)
    {
        List<List<int>> result = new();
        List<string> concatenateNumbers = new();

        int firstNumberIndex = 0;
        int firstNumber = nums[firstNumberIndex];

        for (int j = firstNumberIndex + 1; j < nums.Length - 1; j++)
        {
            for (int k = j + 1; k < nums.Length; k++)
            {
                if (j == nums.Length - 1)
                {
                    firstNumberIndex++;
                    firstNumber = nums[firstNumberIndex];
                }

                if (nums[firstNumberIndex] + nums[j] + nums[k] == 0)
                {
                    var output = new List<int> { nums[firstNumberIndex], nums[j], nums[k] };
                    output.Sort();

                    if (!result.Any(x => x[0] == output[0] && x[1] == output[1] && x[2] == output[2]))
                        result.Add(output);

                    break;
                }
            }
        }

        return result.ToArray();
    }
}
