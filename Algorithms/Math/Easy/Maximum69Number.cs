using System.Text;

namespace Math.Easy;

public static class Maximum69Number
{
    public static int Run(int num)
    {
        char[] chars = num.ToString().ToCharArray();

        int index = Array.IndexOf(chars, '6');

        if (index != -1)
            chars[index] = '9';

        return int.Parse(new string(chars));
    }
}
