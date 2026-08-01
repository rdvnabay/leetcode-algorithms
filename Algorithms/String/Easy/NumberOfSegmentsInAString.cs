namespace String.Easy;

public static class NumberOfSegmentsInAString
{
    public static int Run(string s)
    {
        return s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
