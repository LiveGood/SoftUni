import java.util.Scanner;


public class _05DecToHex
{

	public static void main(String[] args)
	{
		Scanner input = new Scanner(System.in);
		int num = Integer.parseInt(input.nextLine());
		String decToHex = Integer.toHexString(num);
		System.out.printf("%S", decToHex);
		
		
	}

}
