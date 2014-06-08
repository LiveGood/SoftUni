import java.util.Scanner;


public class _04TheSmallestOfThreeNums
{

	public static void main(String[] args)
	{
		Scanner input = new Scanner(System.in);
		System.out.print("a = ");
		double a = Double.parseDouble(input.nextLine());
		System.out.print("b = ");		
		double b = Double.parseDouble(input.nextLine());
		System.out.print("c = ");		
		double c = Double.parseDouble(input.nextLine());
		
		double min = Math.min(a, Math.min(b, c));
		
		if (min % 1 != 0)
		{
			System.out.println("min = " + min);
		}
		else {
			int minInt = (int)min;
			System.out.println("min = " + minInt);
		}
		
	}

}
