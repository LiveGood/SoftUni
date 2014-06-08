using System;

/*
 * Problem 4.	Difference between Dates
    Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. Examples:
    First date
    Second date     Days between
    17.03.2014
    30.04.2014	    44
    ---------- 
    17.03.2014
    17.03.2014      0
    ----------
    14.06.1980
    5.03.2014   	12317
    ----------
    5.03.2014
    3.03.2014   	-2
 */
class DiifBetweenDays
{
    static void Main()
    {
        // endless while loop for eiasier testing :)
        while (true)
        {
            while (true)
            {
                Console.Write("Start date: ");
                DateTime starDate = DateTime.Parse(Console.ReadLine());
                Console.Write("End date: ");
                DateTime EndDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine(DaysBetween(starDate, EndDate));
            }
        }
    }

    private static int DaysBetween(DateTime from, DateTime to)
    {
        int daysBetween = (int)(to - from).TotalDays;
        return daysBetween;
    }

}