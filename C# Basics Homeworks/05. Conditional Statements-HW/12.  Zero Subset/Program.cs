using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int subsetCount = 31;
        int[] nums = new int[5];
        List<int> numsUsed = new List<int>();
 
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        int countZero = 0;

        for (int i = 1; i < subsetCount; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < 5; j++)
            {
                int mask = 1 << j;
                int bit = (mask & i) >> j;
                if (bit == 1)
                {
                    currentSum += nums[j];
                    numsUsed.Add(nums[j]);
                }
            }
            if (currentSum == 0)
            {
                string str = "";
                str += string.Join(" + ", numsUsed);
                str += " = 0";
                Console.WriteLine(str);
                countZero++;
            }
            numsUsed = new List<int>();
        }
    }
}
