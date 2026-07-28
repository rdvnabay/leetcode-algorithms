namespace Algorithms.Solutions.Easy;

public class AssignCookies
{
    public static int Run(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);

        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = result; j < g.Length; j++)
            {
                if (s[i] >= g[j])
                    result++;

                break;
            }
        }

        return result;
    }
}
