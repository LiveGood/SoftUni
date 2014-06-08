import java.util.Scanner;


public class _06CountWordsInText {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Input text below:");
		String sequenceInput = input.nextLine();
		System.out.print("Word to count: ");
		String wordToCount = input.nextLine();
		sequenceInput = sequenceInput.replaceAll("[^a-zA-Z]", " ");
		sequenceInput = sequenceInput.replaceAll("  ", " ").toLowerCase();		
		String[] sequanceArray = sequenceInput.split(" ");
		System.out.println(sequanceArray.length);
		
		int wordCounter = 0;
		for (int i = 0; i < sequanceArray.length; i++) {
			if (sequanceArray[i].equals(wordToCount)) {
				wordCounter++;
			}
		}
		System.out.println(wordCounter);
		
	}

}
