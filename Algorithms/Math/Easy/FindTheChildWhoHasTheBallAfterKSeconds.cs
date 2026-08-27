/**
 * @id         3178
 * @title      Find the Child Who Has the Ball After K Seconds
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-the-child-who-has-the-ball-after-k-seconds/
 */
namespace Math.Easy;

public static class FindTheChildWhoHasTheBallAfterKSeconds
{
    //0 1 2 - time 5:
    public static int Run(int n, int k)
    {
        //for (int i = 0; i < n;)
        //{

        //}

        int i = 0;
        k = k + 1;
        while (k > 0)
        {
            if (i >= 0)
            {
                i++;
            }

            else if (i == n - 1)
            {
                i--;
            }

            k--;
        }

        return i;
    }
}
