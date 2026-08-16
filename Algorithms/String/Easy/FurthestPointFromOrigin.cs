namespace String.Easy;

public static class FurthestPointFromOrigin
{
    //_R__LL_
    public static int Run(string moves)
    {
        int left = 0;
        int right = 0;
        int unknow = 0;

        foreach (var move in moves)
        {
            _ = move switch
            {
                'L' => left++,
                'R' => right++,
                _ => unknow++
            };
        }

        return Math.Abs(left - right) + unknow;
    }
}
