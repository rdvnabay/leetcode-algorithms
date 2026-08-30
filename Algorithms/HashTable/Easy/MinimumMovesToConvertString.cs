namespace HashTable.Easy;

public static class MinimumMovesToConvertString
{
    public static int Run(string s)
    {
        int index = 0;
        int minMoves = 0;

        while (index < s.Length)
        {
            if (s[index] == 'X')
            {
                minMoves++;
                index += 3;
            }
            else
            {
                index++;
            }
        }

        return minMoves;
    }
}
