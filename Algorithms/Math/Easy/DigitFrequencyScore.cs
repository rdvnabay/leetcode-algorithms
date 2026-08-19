namespace Math.Easy;

public static class DigitFrequencyScore
{
    //55521
    public static int Run(int n)
    {
        int total = 0;

        while (n > 0)
        {
            int remainder = n % 10;
            total += remainder;
            n /= 10;
        }

        return total;
    }

    //Alternative solutions
    static int Solution2(int n)
    {
        Dictionary<int, int> dict = new();

        while (n > 0)
        {
            int remainder = n % 10;
            if (!dict.TryGetValue(remainder, out int count))
                dict[remainder] = 1;
            else
                dict[remainder] = count + 1;

            n /= 10;
        }

        int total = 0;

        foreach (var item in dict)
            total += item.Value * item.Key;

        return total;
    }
}
