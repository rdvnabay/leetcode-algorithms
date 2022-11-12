namespace Algorithms.Solutions.Easy;

public static class FindTheDifference
{
    public static char Run(string s, string t)
    {

        //Later solution
        char diff = '\0';

        HashSet<char> left = new();
        HashSet<char> right = new();

        for (int i = 0; i < t.Length; i++)
        {
            if (s.Length != i)
                left.Add(s[i]);

            right.Add(t[i]);
        }

        try
        {
            diff = right.Where(x => !left.Contains(x)).First();
        }
        catch (InvalidOperationException ex)
        {
            return t[t.Length - 1];
        }

        return diff;
    }
}
