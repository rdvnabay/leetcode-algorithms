namespace String.Easy;

public static class TrafficSignalColor
{
    public static string Run(int timer)
    {
        return timer switch
        {
            0 => "Green",
            30 => "Orange",
            > 30 and <= 90 => "Red",
            _ => "Invalid"
        };
    }
}
