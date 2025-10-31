namespace Algorithms.Solutions.Easy;

public static class TheTwoSneakyNumbersOfDigitville
{
    public static int[] Run(int[] nums)
    {
        List<int> uniqueNums = new();
        List<int> duplicateNums = new();

        foreach (int num in nums)
        {
            if (!uniqueNums.Contains(num))
                uniqueNums.Add(num);
            else
                duplicateNums.Add(num);
        }

        var result = duplicateNums.ToArray();
        return result;
    }
}
