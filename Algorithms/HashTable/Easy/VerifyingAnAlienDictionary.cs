namespace Algorithms.HashTable.Easy;

public static class VerifyingAnAlienDictionary
{
    //  { "word", "world", "row" }, "worldabcefghijkmnpqstuvxyz");
    public static bool Run(string[] words, string order)
    {
        for (int i = 0; i < words.Length - 1; i++)
        {
            string left = words[i];
            string right = words[i + 1];

            int j = 0;
            bool isMatch = true;

            while (j < left.Length && j < right.Length)
            {
                if (left[j] != right[j])
                {
                    isMatch = false;

                    int leftCharIndex = order.IndexOf(left[j]);
                    int rightCharIndex = order.IndexOf(right[j]);

                    if (rightCharIndex < leftCharIndex)
                        return false;

                    break;
                }
                j++;
            }

            if (isMatch)
            {
                if (left.Length > right.Length)
                    return false;
            }
        }

        return false;
    }
}
