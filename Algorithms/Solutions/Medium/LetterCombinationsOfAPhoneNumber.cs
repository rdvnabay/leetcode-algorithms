namespace Algorithms.Solutions.Medium;

public static class LetterCombinationsOfAPhoneNumber
{
    public static IList<string> Run(string digits)
    {
        int counter = 0;
        List<string> result = new();
        string value = "";

        Dictionary<char, List<char>> keys = new();
        keys.Add('2', new List<char>() { 'a', 'b', 'c' });
        keys.Add('3', new List<char>() { 'd', 'e', 'f' });
        keys.Add('4', new List<char>() { 'g', 'h', 'i' });
        keys.Add('5', new List<char>() { 'j', 'k', 'l' });
        keys.Add('6', new List<char>() { 'm', 'n', 'o' });
        keys.Add('7', new List<char>() { 'p', 'q', 'r', 's' });
        keys.Add('8', new List<char>() { 't', 'u', 'v' });
        keys.Add('9', new List<char>() { 'w', 'x', 'y', 'z' });

        List<List<char>> allCombinations = new();

        foreach (char digit in digits)
        {
            if (keys.TryGetValue(digit, out List<char> letters))
                allCombinations.Add(letters);
        }

        foreach (var item in allCombinations[0])
        {
            counter++;
            value += item;
            //if (counter != digits.Length)
                //Recursive(allCombinations[counter], value);
        }

        return null;
    }

    public static void Recursive(List<char> combination, string value)
    {
        foreach (var item in combination)
        {
            value += item;
        }
    }
}
