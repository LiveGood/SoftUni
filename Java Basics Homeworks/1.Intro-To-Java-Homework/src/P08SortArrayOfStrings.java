import java.util.*;

public class P08SortArrayOfStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int stringsNumber = Integer.parseInt(input.nextLine());
		String[] stringArray = new String[stringsNumber];
		 
		for (int i = 0; i < stringArray.length; i++) {
			stringArray[i] = input.nextLine();
		}
		Arrays.sort(stringArray);
		
		for (String string : stringArray) {
			System.out.println(string);
		}
		
	}

}
