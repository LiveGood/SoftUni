import java.util.Scanner;


public class _01RectangleArea
{

	public static void main(String[] args)
	{
		Scanner input = new Scanner(System.in);
		System.out.print("a = ");
		int a = Integer.parseInt(input.nextLine());
		System.out.print("b = ");		
		int b = Integer.parseInt(input.nextLine());
		int area = a * b;
		
		System.out.println("area = " + area);
		
		
	}

}
