using System.Text;

namespace Greedy.Easy;

public class LatestTimeByReplacingHiddenDigits
{
    public static string Run(string time)
    {
        char[] result = new char[5];

        char h1 = time[0];
        char h2 = time[1];
        char m1 = time[3];
        char m2 = time[4];

        if (h1 == '?')
            result[0] = '2';
        else
            result[0] = h1;

        if (h2 == '?')
        {
            if (h1 == '?')
                result[1] = '3';
            if (h1 == '2')
                result[1] = '3';
            else
                result[1] = '9';
        }
        else
            result[1] = h2;

        result[2] = ':';

        if (m1 == '?')
            result[3] = '5';
        else
            result[3] = m1;

        if (m2 == '?')
            result[4] = '9';
        else
            result[4] = m2;

        return new string(result);
    }
}
