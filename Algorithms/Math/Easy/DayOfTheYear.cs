namespace Math.Easy;

public static class DayOfTheYear
{
    public static int Run(string date)
    {
        var parts = date.Split('-');
        int year = int.Parse(parts[0]);
        int month = int.Parse(parts[1]);
        int day = int.Parse(parts[2]);

        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        int totalDays = day;
        for (int i = 0; i < month - 1; i++)
            totalDays += daysInMonth[i];

        if (month > 2 && IsLeapYear(year))
            totalDays += 1;

        return totalDays;
    }

    static bool IsLeapYear(int year)
    {
        if (year % 400 == 0)
            return true;

        if (year % 4 == 0 && year % 100 != 0)
            return true;

        return false;
    }
}
