/**
 * @id         455
 * @title      Assign Cookies
 * @topic      greedy
 * @difficulty Easy
 * @link       https://leetcode.com/problems/assign-cookies/
 */
namespace Algorithms.Greedy.Easy;

public class AssignCookies
{
    public static int Run(int[] g, int[] s)
    {
        System.Array.Sort(g);
        System.Array.Sort(s);

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


