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
