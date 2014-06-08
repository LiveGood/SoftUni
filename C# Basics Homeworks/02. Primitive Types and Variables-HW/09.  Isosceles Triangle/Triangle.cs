using System;
using System.Text;
/*
   Problem 8.	Isosceles Triangle
   Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
      ©
     © ©
    ©   ©
   © © © ©
   Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and the console font.
 */

class Triangle
{
    // this program will create triangle with input size:  3 < length <= 40
    static void Main()
    {
        
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Triangle size: ");
        int length = int.Parse(Console.ReadLine());
        char copyRight = '\u00A9';

        string emptySpaceBefore = new string(' ', length - 1);
        Console.WriteLine(emptySpaceBefore + copyRight);

        for (int i = 1, k = length - 2; k > 0; i += 2, k-- )
        {
            emptySpaceBefore = new string(' ', k);
            string emtySpaceMiddle = new string(' ', i);
            Console.WriteLine(emptySpaceBefore + copyRight + emtySpaceMiddle + copyRight);
        }

        for (int i = 0; i < length; i++)
	    {
            Console.Write(copyRight + " ");    	 
        }
        Console.WriteLine();

    }
}
