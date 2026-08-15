using System.Text;

namespace String.Easy;

public static class DefangingAnIPAddress
{
    public static string Run(string address)
    {
        StringBuilder sb = new();

        for (int i = 0; i < address.Length; i++)
        {
            if (address[i] != '.')
                sb.Append(address[i]);
            else
                sb.Append("[.]");
        }

        return sb.ToString();
    }
}
