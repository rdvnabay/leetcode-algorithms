namespace Algorithms.String.Easy;

public static class CrawlerLogFolder
{
    public static int Run(string[] logs)
    {
        //"d1/","d2/","../","d21/","./"

        //["d1/", "d2/", "./", "d3/", "../", "d31/"]

        //["d1/", "../", "../", "../"]

        int counter = 0;

        foreach (var log in logs)
        {
            if (log.StartsWith("../"))
            {
                if (counter > 0)
                    counter--;
            }
            else if (!log.StartsWith("./"))
                counter++;
        }

        return counter;
    }
}
