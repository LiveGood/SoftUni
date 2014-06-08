using System;
/*
    Numbers in Interval Dividable by Given Number
    Write a program that reads two positive integer numbers and prints how many numbers  
    p exist between them such that the reminder of the division by 5 is 0. Examples:
 */
class DivedeBy5Count
{
    static void Main()
    {
        int nFrom = int.Parse(Console.ReadLine());
        int nTo = int.Parse(Console.ReadLine());
        int p = 0;

        
        while (nFrom % 5 != 0)
        {
            // making nFrom dividele by 5 with no remainder
            nFrom++;    
        }
        // adding 5 to the new value of nFrom 
        for (int i = nFrom; i <= nTo; i += 5)
        {
            p++;
            // use lines below for visual representation of the numbers
            //Console.Write("{0} ", i);
            //if (p % 10 == 0) Console.WriteLine();
    	}
        Console.WriteLine();
        Console.WriteLine("p = {0}", p);
    }
}
