namespace Algorithms.Solutions.Easy;

public static class RobotReturnToOrigin
{
    public static bool Run(string moves)
    {
        Dictionary<char, int> xCoords = new();
        Dictionary<char, int> yCoords = new();

        foreach (var move in moves)
        {
            if (move == 'L' || move == 'R')
            {
                if (!xCoords.ContainsKey(move))
                    xCoords[move] = 1;
                else
                    xCoords[move]++;
            }

            if (move == 'U' || move == 'D')
            {
                if (!yCoords.ContainsKey(move))
                    yCoords[move] = 1;
                else
                    yCoords[move]++;
            }
        }
        
        if (!xCoords.Any() || xCoords.Count == 2 && xCoords.GetValueOrDefault('L') == xCoords.GetValueOrDefault('R'))
        {
            if (!yCoords.Any() || yCoords.Count == 2 && yCoords.GetValueOrDefault('U') == yCoords.GetValueOrDefault('D'))
            {
                return true;
            }
        }

        return false;
    }
}
