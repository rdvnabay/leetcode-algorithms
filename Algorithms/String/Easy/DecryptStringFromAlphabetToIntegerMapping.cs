namespace Algorithms.String.Easy;

public static class DecryptStringFromAlphabetToIntegerMapping
{
    public static string Run(string s)
    {
        //10#11#12

        //1326#

        if (s.Length == 1)
        {
            var test = s[0] - 'a';
            var res = test;
        }

        else if (s.Length == 2)
        {

        }


        for (int i = 0; i < s.Length - 2;)
        {
            if (s[i + 2] == '#')
            {
                var res = s[0] + s[i] - 'a';
                i += 3;
            }
            else
            {
                var res = s[i] - 'a';
                i++;
            }
        }
        return "";
    }
}
