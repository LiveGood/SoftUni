import java.util.Scanner;

import com.sun.javafx.geom.Area;


public class _02RectangleArea
{

	public static void main(String[] args)
	{
		Scanner input = new Scanner(System.in);
		int aX = Integer.parseInt(input.nextLine());
		int aY = Integer.parseInt(input.nextLine());
		int bX = Integer.parseInt(input.nextLine());
		int bY = Integer.parseInt(input.nextLine());
		int cX = Integer.parseInt(input.nextLine());
		int cY = Integer.parseInt(input.nextLine());
		
		int area = Math.abs((aX * (bY - cY) + bX * (cY - aY) + cX * (aY - bY)) / 2);
		System.out.println("Area = " + area);
		
	}

}
