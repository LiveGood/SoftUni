using System;
/*
    Problem 3.	Check for a Play Card
    Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write
    a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
    character	Valid card sign?
    5	        yes
    1	        no
    Q	        yes
    q	        no
    P	        no
    10	        yes
    500	        no
 */
class Program
{
    static void Main()
    {
        string cardSign = Console.ReadLine();
        char charCard;
        bool tryChar = char.TryParse(cardSign, out charCard);

        if ((charCard >= '2' && charCard <= '9') || cardSign == "10" || charCard == 'J'
            || charCard == 'Q' || charCard == 'K' || charCard == 'A')
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}