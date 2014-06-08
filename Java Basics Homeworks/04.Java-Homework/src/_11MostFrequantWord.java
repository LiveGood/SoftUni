import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;


public class _11MostFrequantWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String textInput = input.nextLine().toLowerCase();
		textInput = textInput.replaceAll("[!.,?;:/]+", "");
		String[] splitWords = textInput.split("\\s");

		int bestCounter = 0;
		Set<String> mostRepeatedWords = new TreeSet<>();
		ArrayList<String> noRepeatCount = new ArrayList<>();
		
		for (int i = 0; i < splitWords.length; i++) {
			int counter = 1;
			String wordToCheck = splitWords[i];
			if (noRepeatCount.contains(wordToCheck)) {
				continue;
			}
			
			for (int j = i + 1; j < splitWords.length; j++) {
				if (splitWords[j].equals(wordToCheck)) {
					counter++;
				}
				
				if (counter == bestCounter ){
					mostRepeatedWords.add(wordToCheck);
				}
				else if (counter > bestCounter) {
					bestCounter = counter;
					mostRepeatedWords.clear();
					mostRepeatedWords.add(wordToCheck);
				}
			}
			noRepeatCount.add(wordToCheck);
		}

		for (String string : mostRepeatedWords) {
			System.out.printf("%s -> %d times \n", string, bestCounter);
		}
	}

}
