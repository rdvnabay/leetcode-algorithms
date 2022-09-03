namespace Algorithms.Solutions.Easy;

public class RomanToInteger
{
    public static int Run(string s)
    {
        int total = 0;

        Dictionary<char, int> romanDictionary = new()
        {
          {'I',1},
          {'V',5 },
          {'X',10 },
          {'L',50 },
          {'C',100 },
          {'D',500 },
          {'M',1000 }
        };

        for (int i = 0; i < s.Length; i++)
        {
            if (i == s.Length - 1)
                return total += romanDictionary[s[i]];

            int current = romanDictionary[s[i]];
            int next = romanDictionary[s[i + 1]];

            if (current >= next)
                total += current;

            else if (current < next)
            {
                total += next - current;
                i++;
            }
        }

        return total;
    }
}
