import java.util.Scanner;


public class _09PointsInsideHouse
{

	public static void main(String[] args)
	{
		while (true)
		{
			Scanner input = new Scanner(System.in);
			String pointsString = input.nextLine();
			String[] pointsArray = pointsString.split(" ");
			double xP= Double.parseDouble(pointsArray[0]);
			double yP= Double.parseDouble(pointsArray[1]);
			
			// triangle coordinates;
			double x1 = 12.5;
			double y1 = 8.5;
			double x2 = 17.5;
			double y2 = 3.5;
			double x3 = 22.5;
			double y3 = 8.5;
						
			boolean insideTriangle = pointInsideTriangle(x1, y1, x2, y2, x3,  y3, xP,  yP);
			boolean inLeftRectangle = (xP >= 12.5 && xP <= 17.5) && (yP >= 8.5 && yP <= 13.5);
			boolean inRightRectangle = (xP >= 20 && xP <= 22.5) && (yP >= 8.5 && yP <= 13.5);
			
			if (insideTriangle || inLeftRectangle || inRightRectangle)
			{
				System.out.println("Inside");
			} 
			else {
				System.out.println("Outside");
			}
			
		}
	}

	private static double calcTriangleArea(
			double x1, double y1, 
			double x2, double y2, 
			double x3, double y3)
	{
	   return Math.abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
	}
	private static boolean pointInsideTriangle(
			double x1, double y1, 
			double x2, double y2,
			double x3, double y3,
			double xP, double yP)
	{
		double areaABC = calcTriangleArea(x1, y1, x2, y2, x3, y3);
		double areaPAB = calcTriangleArea(xP, yP, x1, y1, x2, y2);
		double areaPBC = calcTriangleArea(xP, yP, x2, y2, x3, y3);
		double areaPAC = calcTriangleArea(xP, yP, x1, y1, x3, y3);
		boolean insideOrNot = areaABC == areaPAB + areaPAC + areaPBC;
		return insideOrNot;
	}
	

}
