/**
 * @id         551
 * @title      Student Attendance Record I
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/student-attendance-record-i/
 */
namespace String.Easy;

public static class StudentAttendanceRecordI
{
    //PPALLL
    public static bool Run(string s)
    {
        int absentCount = 0;
        int lateCount = 0;

        foreach (var item in s)
        {
            if (item == 'A')
            {
                absentCount++;
                lateCount = 0;
                if (absentCount > 1)
                    return false;
            }

            else if (item == 'L')
            {
                lateCount++;
                if (lateCount > 2)
                    return false;
            }
            else
            {
                lateCount = 0;
            }
        }

        return true;
    }
}


