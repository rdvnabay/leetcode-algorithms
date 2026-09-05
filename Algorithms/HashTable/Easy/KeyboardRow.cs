namespace HashTable.Easy;

public static class KeyboardRow
{
    public static string[] Run(string[] words)
    {
        string firstRow = "qwertyuiop";
        string secondRow = "asdfghjkl";
        string thirdRow = "zxcvbnm";

        List<string> result = new();

        foreach (var word in words)
        {
            bool[] checkRows = new bool[3];

            foreach (var c in word.ToLower())
            {
                if (firstRow.Contains(c))
                    checkRows[0] = true;

                else if (secondRow.Contains(c))
                    checkRows[1] = true;

                else if (thirdRow.Contains(c))
                    checkRows[2] = true;
            }

            if (checkRows.Count(x => x == true) == 1)
                result.Add(word);
        }

        return result.ToArray();
    }
}
