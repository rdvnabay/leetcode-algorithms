namespace Algorithms.Solutions.Easy;

public class RomanToInteger
{
    public static int Run(string s)
    {
        int output = 0;
        int numberOfDigits = 0;

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
            if (romanDictionary.TryGetValue(s[i], out int result))
            {
                if (i == 0)
                    numberOfDigits = result.ToString().Length;

                if (s[i + 1] < s.Length)
                {
                    if (romanDictionary.TryGetValue(s[i+1], out int next))
                    {

                    }
                }
            }
        }

        //foreach (char item in s)
        //{
        //    if (romanDictionary.TryGetValue(item, out int result))
        //    {
        //        numberOfDigits = result.ToString().Length;
        //    }


        //}
        return 0;
    }
}
