namespace Greedy.Easy;

public static class MinimumTimeToTypeWordUsingSpecialTypewriter
{
    //bza
    public static int Run(string word)
    {
        int total = 0;

        //a - b 1+1 | 0 1 25
        //b - z 2+1 | 1 25 1
        //z - a 1+1 | 25

        for (int i = 0; i < word.Length - 1; i++)
        {
            var current = word[i] - 'a';
            var next = word[i + 1] - 'a';
            var next2 = 26 - next;
            int min = Math.Min(Math.Abs(current + next2), Math.Abs(current - next));
            total += min + 1;
        }

        return total;
    }
}
