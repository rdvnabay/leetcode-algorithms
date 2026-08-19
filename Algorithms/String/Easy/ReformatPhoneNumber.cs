namespace String.Easy;

public static class ReformatPhoneNumber
{
    //123 4-567
    //123-45-67
    public static string Run(string number)
    {
        var numbers = string.Join(' ', number.Split(' ', '-'));

        List<char> digits = new();
        foreach (var item in number)
        {
            if (char.IsDigit(item))
                digits.Add(item);
        }

        return "";
    }
}
