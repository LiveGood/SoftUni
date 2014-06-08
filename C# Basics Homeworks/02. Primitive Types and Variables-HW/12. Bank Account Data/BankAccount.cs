using System;
using System.Threading;

// Problem 12.	Bank Account Data
// A bank account has a holder name (first name, middle name and last name), available
// amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the 
// account. Declare the variables needed to keep the information for a single bank account
// using the appropriate data types and descriptive names.

class BankAccount
{
    static void Main()
    {

        string firstName = "Ivancho";
        string middleName = "Margaritkev";
        string lastName = "Minzuharov";
        string bankName = "Raifasen";
        decimal balance = 123456.634M;
        // card numbers and IBANs are never used as values so they can be strings
        string iBan = "BG RGB 6561 4876 4868 1973";
        string card1 = "4864 8468 6468 0031 ";
        string card2 = "8663 4458 1570 0056 ";
        string card3 = "8663 4458 1570 0056 "; 
    }
}

