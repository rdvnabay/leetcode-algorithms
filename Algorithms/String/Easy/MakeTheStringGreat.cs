/**
 * @id         1544
 * @title      Make The String Great
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/make-the-string-great/
 */
namespace String.Easy;

public static class MakeTheStringGreat
{
    //abBAcC
    public static string Run(string s)
    {
        List<char> chars = new();

        //while (true)
        //{
            for (int i = 0; i < s.Length - 1;)
            {
                if (Math.Abs(s[i] - s[i + 1]) == 32)
                {
                    i += 2;
                }
                else
                {
                    chars.Add(s[i]);
                    i++;
                }
            }
        //}
       
        return "";
    }
}


