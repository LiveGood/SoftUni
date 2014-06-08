using System;

/*
   Problem 9.	Play with Int, Double and String
   Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
   If the variable is int or double, the program increases it by one. If the variable is a string, 
   the program appends "*" at the end. Print the result at the console. Use switch statement. 
 */
class PlayIt
{
    static void Main()
    {
        Console.Write("Enter integer 1 to 3: 1 for int, 2 for double and 3 for string: ");
        int n;
        do
        {
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (n > 0 && n < 4)
            {
                break;    
            }
            Console.Write("Invalid input, try again: ");
        } while (true);
        switch (n)
        {
            case 1:
                Console.WriteLine("Double : ");
                int intInput = int.Parse(Console.ReadLine());
                Console.WriteLine(intInput + 1);
                break;
            case 2:
                Console.WriteLine("Double : ");
                double doubleInput = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleInput + 1);
                break;
            case 3:
                Console.WriteLine("String: ");
                string strinInput = Console.ReadLine();
                Console.WriteLine(strinInput + '*');
                break;
            default:
                break;
        }
    }
}
