import java.util.Scanner;


public class _03PointInsideFiure
{

	public static void main(String[] args)
	{
		while (true)
		{
			Scanner input = new Scanner(System.in);
			String pointsString = input.nextLine();
			String[] pointsArray  = pointsString.split(" ");
			double x = Double.parseDouble(pointsArray[0]);
			double y = Double.parseDouble(pointsArray[1]);
			
			boolean inUpRectangle = (x >= 12.5 && x <= 22.5) && (y >= 6 && y <= 8.5);
			boolean inLeftRectangle = (x >= 12.5 && x <= 17.5) && (y >= 8.5 && y <= 13.5);
			boolean inRightRectangle = (x >= 20 && x <= 22.5) && (y >= 8.5 && y <= 13.5);
			
			if (inUpRectangle || inLeftRectangle || inRightRectangle)
			{
				System.out.println("Inside");
			}
			else {
				System.out.println("Outside");
			}
		}
		
	}

}
