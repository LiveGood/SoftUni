import java.util.Scanner;


public class _03LargestSequenseOfEquallStrings {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String sequenceInput = input.nextLine();
		String[] sequanceArray = sequenceInput.split(" ");
		
		int counter = 1;
		int bestCounter = 1;
		String previousWord = sequanceArray[0];
		String mostRepeatedWord = sequanceArray[0];
		boolean moreThanOneWord = false;
		
		for (int i = 1; i < sequanceArray.length; i++) {
			String currentWord = sequanceArray[i];
			
			if (currentWord.equals(previousWord)) {
				counter++;
				if (counter > bestCounter) {
					bestCounter = counter;
					mostRepeatedWord = currentWord;
				}
				
				if (i == sequanceArray.length - 1 && moreThanOneWord) {
					bestCounter++;
				}
				
			}
			else {
				moreThanOneWord = true;;
				previousWord = currentWord;
				counter = 1;
			}
		}
		
		for (int i = 0; i < bestCounter; i++) {
			System.out.print(mostRepeatedWord + " ");
			
		}
		
	}
}