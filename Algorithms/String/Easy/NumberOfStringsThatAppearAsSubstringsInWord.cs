namespace String.Easy;

public static class NumberOfStringsThatAppearAsSubstringsInWord
{
    //Input: patterns = ["a","abc","bc","d"], word = "abc"
    //Output: 3
    public static int Run(string[] patterns, string word)
    {
        int counter = 0;

        foreach (var pattern in patterns)
        {
            foreach (var letter in pattern)
            {
                if (word.Contains(letter))
                {
                    counter++;
                    break;
                }
            }
        }

        return counter;
    }
}
