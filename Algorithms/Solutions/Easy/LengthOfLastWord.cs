namespace Algorithms.Solutions.Easy;

public class LengthOfLastWord
{
    public static int Run(string s)
    {
        return SolutionOne(s);
        //SolutionTwo(s);
    }

    private static int SolutionOne(string s)
    {
        List<char> chars = new();

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i].Equals(' '))
            {
                if (chars.Count > 0)
                    break;
                else
                    continue;
            }
            else
                chars.Add(s[i]);
        }

        return chars.Count();
    }

    private static int SolutionTwo(string s) => s.Trim().Split(' ').Last().Count();
}
