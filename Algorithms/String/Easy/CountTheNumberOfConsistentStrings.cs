namespace String.Easy;

public static class CountTheNumberOfConsistentStrings
{
    public static int Run(string allowed, string[] words)
    {
        int counter = 0;
        HashSet<char> hashSet = new(allowed);

        foreach (var word in words)
        {
            bool isConsistent = true;

            foreach (var letter in word)
            {
                if (!hashSet.Contains(letter))
                {
                    isConsistent = false;
                    break;
                }
            }

            if (isConsistent)
                counter++;
        }

        return counter;
    }
}
