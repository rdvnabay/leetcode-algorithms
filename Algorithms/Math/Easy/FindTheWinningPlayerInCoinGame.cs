/**
 * @id         3222
 * @title      Find the Winning Player in Coin Game
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-the-winning-player-in-coin-game/
 */
namespace Math.Easy;

public static class FindTheWinningPlayerInCoinGame
{
    //4 11
    public static string Run(int x, int y)
    {
        int numberOfMoves = 0;

        while (x >= 1 && y >= 4)
        {
            x--;
            y -= 4;
            numberOfMoves++;
        }

        return numberOfMoves % 2 != 0 ? "Alice" : "Bob";
    }
}


