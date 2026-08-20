/**
 * @id         1823
 * @title      Find the Winner of the Circular Game
 * @topic      array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/find-the-winner-of-the-circular-game/
 */
namespace Array.Medium;

public static class FindtheWinnerOfTheCircularGame
{
    //5 2
    public static int Run(int n, int k)
    {
        List<int> list = new();

        for (int i = 1; i <= n; i++)
            list.Add(i);

        int counter = 0;

        while (list.Count > 1)
        {
            for (int i = 0; i < list.Count; i++)
            {
                counter++;

                if (counter == k)
                {
                    list.RemoveAt(i);
                    counter = 1;
                }
            }
        }

        return list[0];
    }
}


