import java.util.Scanner;

// Problem 7.	Count Substring Occurrences
// Write a program to find how many times given string appears in given text 
// as substring. The text is given at the first input line. The search string is
// given at the second input line. The output is an integer number. Please 
// ignore the character casing. Examples:


class _07CountSpecifiedSubstring {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Input text below:");
		String textInput = input.nextLine().toLowerCase();
		System.out.println("Input substring to count:");
		String substingInput = input.nextLine();
			
		System.out.println(countSubstrings(textInput, substingInput));
		
	}

	private static int countSubstrings(String textInput, String substingInput) {
		int counter = 0;
		int substringLenght = substingInput.length();		
		int maxSubstringToGet = textInput.length() - substringLenght + 1;	
		for (int i = 0; i < maxSubstringToGet; i++) {
			String checkSubstring = textInput.substring(i, i + substringLenght);
			
			if (checkSubstring.equals(substingInput)) {
				counter++;
			}
		}
		return counter;
	}

}


