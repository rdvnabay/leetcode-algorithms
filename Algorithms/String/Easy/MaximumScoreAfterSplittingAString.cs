namespace String.Easy;

public static class MaximumScoreAfterSplittingAString
{
    public static int Run(string s)
    {
        int zeroEnd = 0;
        int oneStart = 1;
        int n = s.Length - 1;
        int maxValue = int.MinValue;

        while (n > 0)
        {
            int zerosTotal = 0;
            int onesTotal = 0;

            for (int i = 0; i <= zeroEnd; i++)
            {
                if (s[i] == '0')
                    zerosTotal++;
            }

            for (int j = oneStart; j <= s.Length - 1; j++)
            {
                if (s[j] == '1')
                    onesTotal++;
            }

            if (zerosTotal + onesTotal > maxValue)
                maxValue = zerosTotal + onesTotal;

            zeroEnd++;
            oneStart++;
            n--;
        }


        return maxValue;
    }
}
