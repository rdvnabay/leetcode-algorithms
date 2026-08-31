namespace String.Easy;

public static class CountValidPrefixes
{
    public static int Run(string s)
    {
        int validCount = 0;
        int zerosCount = 0;
        int onesCount = 0;

        foreach (var c in s)
        {
            if (c == '0')
                zerosCount++;
            else
                onesCount++;

            if (Math.Abs(zerosCount - onesCount) <= 1)
                validCount++;
        }

        return validCount;
    }
}
