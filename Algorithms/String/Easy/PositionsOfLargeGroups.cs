namespace String.Easy;

public static class PositionsOfLargeGroups
{
    //abcdddeeeeaabbbcd
    //babaaaabbb
    //[[3,5],[6,9],[12,14]]
    public static IList<IList<int>> Run(string s)
    {
        int counter = 1;
        char currentChar = s[0];
        List<IList<int>> result = new();

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == currentChar)
            {
                counter++;
            }
            else
            {
                if (counter >= 3)
                {
                    int startIndex = i - counter;
                    result.Add(new List<int>() { startIndex, i - 1 });
                }
                currentChar = s[i];
                counter = 1;
                continue;
            }

            if (counter >= 3)
            {
                result.Add(new List<int>() { i - 1, s.Length - 1 });
            }
        }

        return result;
    }
}
