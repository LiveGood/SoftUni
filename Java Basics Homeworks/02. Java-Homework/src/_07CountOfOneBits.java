import java.util.Scanner;


public class _07CountOfOneBits
{

	public static void main(String[] args)
	{
		Scanner input = new Scanner(System.in);
		System.out.print("a = ");
		int a = Integer.parseInt(input.nextLine());
	
		System.out.println(Integer.bitCount(a));
	}

}
