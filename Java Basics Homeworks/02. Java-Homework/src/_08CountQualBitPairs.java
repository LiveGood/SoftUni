import java.util.Scanner;


public class _08CountQualBitPairs
{

	public static void main(String[] args)
	{
		Scanner input = new Scanner(System.in);
		int num = Integer.parseInt(input.nextLine());
		
		int nextBit = num & 1;
		int countBits = 0;
		int numCopy = num;
		while (numCopy > 0)
		{
			numCopy /= 2;
			countBits++;
		}
		
		int pairsCount = 0;
		for (int i = 1; i < countBits; i++)
		{
			int mask = num >> i;
			if ((mask & 1) == nextBit)
			{
				pairsCount++;
			} else {
				nextBit = mask & 1;
			}
		}
		System.out.println(pairsCount);
		
	}

}
