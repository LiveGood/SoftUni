using System;

class HexToDec
{
    static void Main()
    {
        string hexInput = Console.ReadLine().ToUpper();
        int stringLenght = hexInput.Length - 1;
        long makeInt = 0;
        long decValue = 0;

        //this method uses char array
        char[] hexCharArray = hexInput.ToCharArray();
        Array.Reverse(hexCharArray);
        for (int i = 0; i < hexCharArray.Length; i++)
        {
            if (hexCharArray[i] >= '0' && hexCharArray[i] <= '9')
            {
                // chars 0 to 9 have integer repsentation 48 to 57 
                // substracting 48 or '0' from them gives the real value 0 to 9
                makeInt = hexCharArray[i] - 48;
            }
            else if (hexCharArray[i] >= 'A' && hexCharArray[i] <= 'F')
            {
                // A to F = 65 to 70 , substracting 55 gives value 10 to 15
                makeInt = hexCharArray[i] - 55;
            }
            // the formula for converting dec to hex is 
            // If ABC is the hexInput then decValue = (C(12) * 16^0 )+ (B(11) * 16^1) + (A(10) * 16^2) 
            decValue += makeInt * (long)Math.Pow(16, i);
        }
        Console.WriteLine(decValue);

        //this method uses Substring to extract every seperate char from the string
        //for (int i = 0; i <= stringLenght; i++)
        //{
        //    string getChar = hexInput.Substring(stringLenght - i, 1);
        //    char charConvert = Convert.ToChar(getChar);
        //    if (charConvert < 58)
        //    {
        //        makeInt = charConvert - '0';
        //    }
        //    else
        //    {
        //        makeInt = charConvert - '7';
        //    }
        //    decValue += makeInt * (long)Math.Pow(16, i);
        //}
        //Console.WriteLine(decValue);
    }
}
