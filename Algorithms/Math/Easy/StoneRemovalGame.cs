/**
 * @id         3360
 * @title      Stone Removal Game
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/stone-removal-game/
 */
namespace Math.Easy;

public static class StoneRemovalGame
{
    public static bool Run(int n)
    {
        int stonesToRemove = 10;
        int moveCount = 0;

        while (n - stonesToRemove >= 0)
        {
            n = n - stonesToRemove;
            stonesToRemove--;
            moveCount++;
        }

        return moveCount % 2 == 1;
    }
}


