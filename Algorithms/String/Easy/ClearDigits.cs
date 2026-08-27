/**
 * @id         3174
 * @title      Clear Digits
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/clear-digits/
 */
namespace String.Easy;

public static class ClearDigits
{
    //cb34 - > ""
    //abc - > "abc"
    //abc3d
    public static string Run(string s)
    {
        bool hasDigit = true;

        List<char> chars = new(s);

        //while (hasDigit)
        //{
        //    for (int i = 0; i < chars.Count - 1;)
        //    {
        //        if (char.IsDigit(chars[i + 1]))
        //        {
        //            i += 2;
        //            hasDigit = true;
        //            break;
        //        }
        //        else
        //        {
        //            chars.Add(chars[i]);
        //            hasDigit = false;
        //            i++;
        //        }
        //    }
        //    chars.Add(chars[chars.Count - 1]);
        //}

      


        var test = "";

        //for (int i = 0; i < s.Length - 1;)
        //{
        //    char[] result = new char[s.Length / 2];
        //    if (char.IsDigit(s[i + 1]))
        //    {
        //        i += 2;
        //    }
        //    else
        //    {
        //        result[i] = s[i];
        //        i++;
        //    }
        //}
        return "";
    }
}


