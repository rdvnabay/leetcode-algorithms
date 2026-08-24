namespace Greedy.Easy;

public static class MinimumMovesToConvertString
{
    public static int Run(string s)
    {
        int counter = 0;
        char[] chars = new char[s.Length];

        for (int i = 0; i < s.Length;)
        {
            if (s[i] == 'X')
            {
                chars[i] = 'X';
                chars[i + 1] = 'X';
                chars[i + 2] = 'X';
                i += 3;
            }
            else
            {
                i++;
            }

        }
        return 0;
    }
}
