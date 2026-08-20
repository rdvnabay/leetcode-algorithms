namespace Math.Easy;

public static class CheckIfTheNumberIsFascinating
{
    public static bool Run(int n)
    {
        var nums = string.Concat(n, n * 2, n * 3);
        HashSet<char> set = new(nums);

        return nums.Length == 9 &&
            !set.Contains('0') &&
             set.Count == 9;
    }

    //Alternative solutions
    static bool Solution2(int n)
    {
        return $"{n}{n * 2}{n * 3}".OrderBy(x => x).SequenceEqual("123456789");
    }
}
