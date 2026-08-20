/**
 * @id         1688
 * @title      Count of Matches in Tournament
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-of-matches-in-tournament/
 */
namespace Algorithms.Math.Easy;

public static class CountOfMatchesInTournament
{
    public static int Run(int n)
    {
        int result = 0;

        while (n > 1)
        {
            if (n % 2 == 0)
            {
                n /= 2;
                result += n;
            }
            else
            {
                n /= 2;
                result += n + 1;
            }
        }

        return result;
    }
}


