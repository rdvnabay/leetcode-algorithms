namespace Math.Easy;

public static class MinimumMovesToEqualArrayElementsIII
{
    public static int Run(int[] nums)
    {
        int total = 0;
        int max = nums.Max();

        foreach (var num in nums)
            total += max - num;

        return total;
    }
}
