using System.Text;

namespace String.Easy;

public static class ConvertDateToBinary
{
    public static string Run(string date)
    {
        string[] datePart = date.Split('-');
        StringBuilder result = new();

        foreach (string part in datePart)
        {
            string value = Convert.ToString(int.Parse(part), 2);
            result.Append(value);
            result.Append('-');
        }

        result.Length--;

        return result.ToString();
    }
}
