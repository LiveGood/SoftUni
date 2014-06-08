import java.util.ArrayList;
import java.util.Scanner;

// Problem 2.	Sequences of Equal Strings
// Write a program that enters an array of strings and finds in it 
// all sequences of equal elements. The input strings are given as a 
// single line, separated by a space. Examples:


public class _02SequanceOfEqualStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String sequenceInput = input.nextLine();
		String[] sequanceArray = sequenceInput.split(" ");
		
		String firstString = sequanceArray[0];
		ArrayList<String> equalElements = new ArrayList<>();
		equalElements.add(firstString);
		StringBuilder result = new StringBuilder();
		
		for (int i = 1; i < sequanceArray.length; i++) {
			
			if (firstString.equals(sequanceArray[i])) {
				equalElements.add(sequanceArray[i]);
			}
			else {
				
				for (String string : equalElements) {
					result.append(string + " ");
				}
				result.append("\n");
				
				firstString = sequanceArray[i];
				equalElements.clear();
				equalElements.add(firstString);
			}
		}
		
		for (String string : equalElements) {
			result.append(string + " ");
		}
		result.append("\n");
		
		System.out.print(result);
		
	}

}
