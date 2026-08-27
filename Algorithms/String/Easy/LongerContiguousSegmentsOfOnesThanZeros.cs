namespace String.Easy;

public static class LongerContiguousSegmentsOfOnesThanZeros
{
    //110100010
    public static bool Run(string s)
    {
        int zerosMaxRetryCount = 0;
        int onesMaxRetryCount = 0;


        for (int i = 0; i < s.Length - 1;)
        {
            int zerosCount = 1;
            int onesCount = 1;

            for (int j = i + 1; j < s.Length; j++)
            {
                if (s[i] == s[j])
                {
                    if (s[i] == 0)
                    {
                        zerosCount++;
                    }
                    else
                    {
                        onesCount++;
                    }
                    i++;
                }
                else
                {
                    if (s[i] == 0)
                    {
                        if (zerosCount > zerosMaxRetryCount)
                            zerosMaxRetryCount = zerosCount;
                    }
                    else
                    {
                        if (onesCount > onesMaxRetryCount)
                            onesMaxRetryCount = onesCount;
                    }
                    i += j;
                }
            }
        }

        return false;
    }
}
