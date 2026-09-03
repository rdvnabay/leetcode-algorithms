/**
 * @id         3168
 * @title      Minimum Number of Chairs in a Waiting Room
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/minimum-number-of-chairs-in-a-waiting-room/
 */
namespace String.Easy;

public static class MinimumNumberOfChairsInAWaitingRoom
{
    public static int Run(string s)
    {
        int counter = 0;
        int max = -1;

        foreach (var c in s)
        {
            if (c == 'E')
                counter++;
            else
                counter--;

            if (counter > max)
                max = counter;
        }

        return max;
    }
}
