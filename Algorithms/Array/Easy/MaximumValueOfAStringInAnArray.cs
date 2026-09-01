namespace Array.Easy;

public static class MaximumValueOfAStringInAnArray
{
    public static int Run(string[] strs)
    {
        int maxValue = -1;

        foreach (var str in strs)
        {
            bool isLetter = false;
            foreach (var c in str)
            {
                if (char.IsLetter(c))
                {
                    isLetter = true;
                    maxValue = Math.Max(maxValue, str.Length);
                    break;
                }
            }

            if (!isLetter)
            {
                int num = int.Parse(str);
                maxValue = Math.Max(maxValue, num);
            }
        }

        return maxValue;
    }
}
