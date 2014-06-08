using System;
/*
 *  Problem 16.	Decimal to Hexadecimal Number
    Using loops write a program that converts an integer number to its hexadecimal representation. 
    The input is entered as long. The output should be a variable of type string. 
    Do not use the built-in .NET functionality. Examples:
    decimal	        hexadecimal
    254         	FE
    6883	        1AE3
    338583669684	4ED528CBB4
 */

class DecToHex
{
    static void Main()
    {
        long decValue = long.Parse(Console.ReadLine());
        string hexValue = string.Empty;

        while (decValue > 0)
        {
            int remainder = (int)(decValue % 16);
            //if (remainder == 0)
            //{
            //    remainder++;   
            //}
            decValue /= 16;
            hexValue += remainder < 10? (char)(remainder + '0') : (char)(remainder + '7');

            if (decValue < 16 && decValue > 0)
            {
                hexValue += decValue < 10 ? (char)(decValue + '0') : (char)(decValue + '7');
                break;
            }
        }
        char[] reverseHexValue = hexValue.ToCharArray();
        Array.Reverse(reverseHexValue);
        Console.WriteLine(new string(reverseHexValue));
    }
}
