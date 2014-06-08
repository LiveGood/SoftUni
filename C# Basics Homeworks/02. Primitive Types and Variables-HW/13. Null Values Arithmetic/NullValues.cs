using System;

//Problem 13.	Null Values Arithmetic
// Create a program that assigns null values to an integer and to a double variable.
// Try to print these variables at the console. Try to add some number or
// the null literal to these variables and print the result.

public class NullValues
{
    public static void Main()
    {
        int? intValue = null;
        double? doubleValue = null;
        Console.WriteLine("int value = {0} \ndouble value = {1}", intValue , doubleValue);
        intValue += null;
        doubleValue += 3.14;
        Console.WriteLine("int value = {0} \ndouble value = {1}", intValue, doubleValue);
        // you cant add anything to a nullable type variable (because 3 + null = null)
        // but you can assign new value         
        doubleValue = 3.14;
        intValue = 5;
        Console.WriteLine("int value = {0} \ndouble value = {1}", intValue, doubleValue);

    }
}
