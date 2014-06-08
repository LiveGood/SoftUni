using System;
using System.Globalization;
using System.Threading;

/*
    Problem 10.	* Beer Time
    A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time 
    in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and
    AM / PM designator) and prints “beer time” or “non-beer time” according to the 
    definition above or “invalid time” if the time cannot be parsed. Note that you
    may need to learn how to parse dates and times. 
 */

class BeerTime
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string timeString = Console.ReadLine();
        DateTime timeReal = new DateTime();
        bool trytime = DateTime.TryParse(timeString, out timeReal);
        Console.WriteLine(timeReal);
        if (!trytime) 
        {
            Console.WriteLine("invalid time");   
        }
        else if (timeReal.Hour >= 13 || timeReal.Hour < 3)
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}