using System;

class DecToBin
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        string decN = string.Empty;
        while (n > 0)
        {
            if (n % 2 == 1)
            {
                decN += "1";     
            }
            else
            {
                decN += "0";
            }
            n /= 2;
        }
        char[] charArray = decN.ToCharArray();
        Array.Reverse(charArray);
        decN = new string(charArray);
        Console.WriteLine(decN);

    }
}
