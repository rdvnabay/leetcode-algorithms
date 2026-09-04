namespace String.Easy;

public static class CountSubstringsThatSatisfyKConstraintI
{
    public static int Run(string s, int k)
    {
        int matchCount = 0;
        int range = 1;

        while (range <= s.Length)
        {
            int start = 0;
            int end = range - 1;

            for (int i = 0; i < s.Length - range + 1; i++)
            {
                int onesCount = 0;
                int zerosCount = 0;

                for (int j = start; j <= end; j++)
                {
                    if (s[j] == '0')
                        zerosCount++;

                    else if (s[j] == '1')
                        onesCount++;
                }

                if (zerosCount <= k || onesCount <= k)
                    matchCount++;

                start++;
                end++;
            }
            range++;
        }


        return matchCount;
    }
}
