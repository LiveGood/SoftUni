using System;

class SpiralMatrix1
{
    // This solution uses Console.SetCursorPosition to set the cursor andprint every number .
    static void Main(string[] args)
    {
        Console.WindowWidth = 100;
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int row, col = 0;
        int risingValue = 1;

        for (int i = 0; ; i++)
        {
            for (int j = 1 + i; j <= n - i; j++)
            {
                Console.Write("{0, 4}", risingValue);
                risingValue++;
                col += 4;
            }
            row = Console.CursorTop;
            col = Console.CursorLeft - 4;
            for (int j = 1 + i, k = 1; j <= n - 1 - i; k++, j++)
            {
                Console.SetCursorPosition(col, row + k);
                Console.Write("{0, 4}", risingValue);
                risingValue++;
            }
            row = Console.CursorTop;
            col = Console.CursorLeft - 4;
            for (int j = 1 + i; j <= n - 1 - i; j++)
            {
                col -= 4;
                Console.SetCursorPosition(col, row);
                Console.Write("{0, 4}", risingValue);
                risingValue++;
            }
            col = Console.CursorLeft - 4;
            for (int j = 1 + i, k = 1; j <= n - 2 - i; k++, j++)
            {
                Console.SetCursorPosition(col, row - k);
                Console.Write("{0, 4}", risingValue);
                risingValue++;
            }
            if (risingValue == n * n)
            {
                if (n % 2 != 0)
                {
                    Console.Write("{0, 4}", risingValue);
                    break;
                }
                else
                {
                    break;
                }
            }
        }
        Console.SetCursorPosition(0, 20);
        Console.WriteLine();
    }
}
