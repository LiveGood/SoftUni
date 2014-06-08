using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] nWords = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", 
                              "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen",
                                "twenty", "thirty" , "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};

        string answer = string.Empty;
        if (n <= 20)
        {
            answer = nWords[n];
        }
        else if (n < 100)
        {
            int tens = n / 10;
            int ones = n %10;
            answer = nWords[18 + tens] +  " " + nWords[ones];
        }
        else
        {
            answer = nWords[n / 100] + " hundred ";
            if (n % 100 <= 20 && n % 100 > 0)
            {
                answer += "and " + nWords[n % 100];         
            }
            else if (n % 100 > 20)
            {
                int tens = n / 10 % 10;
                int ones = n % 10;
                answer += "and " + nWords[18 + tens] + " " + nWords[ones];
            }
        }
        Console.WriteLine(UppercaseFirst(answer));
    }
    // method for creating first letter uppper
    static string UppercaseFirst(string s)
    {
        // Check for empty string.
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }
        // Return char and concat substring.
        return char.ToUpper(s[0]) + s.Substring(1);
    }
}
