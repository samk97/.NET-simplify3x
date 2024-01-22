
// Q15. Write a program to check whether a date will fall in which week of the year
// eg: Input: 19/1/2024
// Output: 3rd week

namespace Test3;

partial class Program
{
    //Try to reuse all the const variables and repeated codes
    private static bool IsValidDate(string inputDate)
    {
        string[] date = inputDate.Split('/');
        if (date.Length != 3)
        {
            return false;
        }

        int day = Convert.ToInt32(date[0]);
        int month = Convert.ToInt32(date[1]);
        int year = Convert.ToInt32(date[2]);

        return IsValidDayMonthYear(day, month, year);
    }

    // Check if the day, month, and year are valid
    private static bool IsValidDayMonthYear(int day, int month, int year)
    {
        if (year < 1 || month < 1 || month > 12)
        {
            return false;
        }

        int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (IsLeapYear(year))
        {
            daysInMonth[2] = 29;
        }

        if (day >= 1 && day <= daysInMonth[month])
            return true;
        return false;
    }

    // Check if the year is a leap year
    private static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    // Calculate the week number for a given date
    private static int GetWeekNumber(string inputDate)
    {
        string[] date = inputDate.Split('/');
        int day = Convert.ToInt32(date[0]);
        int month = Convert.ToInt32(date[1]);
        int year = Convert.ToInt32(date[2]);

        int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (IsLeapYear(year))
        {
            daysInMonth[2] = 29;
        }

        int totalDays = day;
        for (int i = 1; i < month; i++)
        {
            totalDays += daysInMonth[i];
        }

        int weekNumber = (totalDays) / 7 + 1;

        return weekNumber;
    }
    static partial void findWeek()
    {
        Console.Write("Enter a date (in the format dd/MM/yyyy): ");
        string inputDate = Console.ReadLine();
        if (IsValidDate(inputDate))
        {
            int weekNumber = GetWeekNumber(inputDate);

            Console.WriteLine($"Output: {weekNumber} week\n\n");
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter a valid date in the format dd/MM/yyyy.\n\n");
        }


    }
}
