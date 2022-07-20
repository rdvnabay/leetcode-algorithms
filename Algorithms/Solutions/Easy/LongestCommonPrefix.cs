namespace Algorithms.Solutions.Easy;

public class LongestCommonPrefix
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="strs"> ["c", "acc", "ccc"] </param>
    /// <returns></returns>
    public static string Run(string[] strs)
    {
        string result = "";
        List<string> commonLetters = new();
        char[] firstItemCharArray = strs[0].ToCharArray();

        if (strs.Length == 1)
            return strs[0];

        if (strs[0].Length == 0)
            return "";

        for (int i = 1; i < strs.Length; i++)
        {
            for (int j = 0; j < strs[i].Length; j++)
            {
                char currentCharacter = strs[i][j];
                if (firstItemCharArray.Length > j)
                {
                    if (currentCharacter == firstItemCharArray[j])
                        result += currentCharacter;
                    else
                        break;
                }                              
            }
            commonLetters.Add(result);
            result = "";
        }
        return commonLetters.Min(x => x);
    }
}
