using System.Text;

namespace String.Easy;

public static class GoalParserInterpretation
{
    //()G(al)()()G
    public static string Run(string command)
    {
        StringBuilder sb = new();

        for (int i = 0; i < command.Length;)
        {
            if (command[i] == 'G')
            {
                sb.Append('G');
                i++;
            }

            else if (command[i] == '(' && command[i + 1] == ')')
            {
                sb.Append('o');
                i += 2;
            }
            else
            {
                sb.Append("al");
                i += 4;
            }

        }
        
        return sb.ToString();
    }
}
