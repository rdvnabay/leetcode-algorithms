namespace String.Easy;

public static class FurthestPointFromOrigin
{
    public static int Run(string moves)
    {
        int left = 0;
        int right = 0;
        int unknown = 0;

        foreach (var move in moves)
        {
            _ = move switch
            {
                'L' => left++,
                'R' => right++,
                _ => unknown++
            };
        }

        return Math.Abs(left - right) + unknown;
    }
}
