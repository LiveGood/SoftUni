using System;

/*
    Problem 6.	Four-Digit Number
    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
    •	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
    •	Prints on the console the number in reversed order: dcba (in our example 1102).
    •	Puts the last digit in the first position: dabc (in our example 1201).
    •	Exchanges the second and the third digits: acbd (in our example 2101).
    The number has always exactly 4 digits and cannot start with 0. Examples:
    n	    sum of digits	reversed	last digit   second and third 
 *                                      in front	 digits exchanged
    2011	4	            1102	    1201	     2101
    3333	12	            3333	    3333	     3333
    9876	30	            6789	    6987	     9786

 */
class FourDigitNum
{
    static void Main()
    {
        Console.WriteLine("Enter 4 digit integer:");
        Console.Write("abcd = ");
        int abcd = int.Parse(Console.ReadLine());
        int a = (abcd / 1000);
        int b = (abcd / 100) % 10;
        int c = (abcd % 100) / 10;
        int d = (abcd % 10);

        int sum = a + b + c + d;
        //this method uses strings
        string reverse = d.ToString() + c.ToString() + b.ToString() + a.ToString();
        string lasInFront = d.ToString() + a.ToString() + b.ToString() + c.ToString();
        string secondThirdChange = a.ToString() + c.ToString() + b.ToString() + d.ToString();

        // this method uses mathematic expressions, comment previous method to try this one. 
        // but if d = 0 this will not work properly

        //int reverse = a + b * 10 + c * 100 + d * 1000;
        //int lasInFront = (abcd / 10) + d * 1000;
        //int secondThirdChange = abcd - (c * 10 + b * 100) + (c * 100 + b * 10);
        
        Console.WriteLine("sum:  {0} \ndcba: {1} \ndabc: {2} \nacbd: {3}"
            , sum, reverse, lasInFront, secondThirdChange);
        
    }
}

