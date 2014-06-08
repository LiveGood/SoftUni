import java.util.Scanner;


public class _06FormatingNumbers
{

	public static void main(String[] args)
	{
		while (true)
		{
			Scanner input = new Scanner(System.in);
			System.out.print("a = ");
			int a = Integer.parseInt(input.nextLine());
			System.out.print("b = ");		
			double b = Double.parseDouble(input.nextLine());
			System.out.print("c = ");		
			double c = Double.parseDouble(input.nextLine());
			
			String aToBinary = String.format("%10s", Integer.toBinaryString(a)).replace(" ", "0");
			System.out.printf("|%-10X|%s|%10.2f|%-10.3f|", a, aToBinary, b, c);
//			
		}

		
	}

}
