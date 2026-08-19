namespace Math.Easy;

public static class MaximumNumberOfBallsInABox
{
    public static int Run(int lowLimit, int highLimit)
    {
        Dictionary<int, int> dict = new();

        for (int i = lowLimit; i <= highLimit; i++)
        {
            int value = i;
            int total = 0;

            while (value > 0)
            {
                int remainder = value % 10;
                total += remainder;
                value /= 10;
            }

            if (!dict.TryGetValue(total, out int count))
                dict[total] = 1;
            else
                dict[total] = count + 1;
        }

        return dict.Max(x => x.Value);
    }
}
