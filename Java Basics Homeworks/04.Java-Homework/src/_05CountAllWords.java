import java.util.Scanner;


public class _05CountAllWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Input text below:");
		String sequenceInput = input.nextLine();
		// the regex expression says to replace all non-letters with empty space
		sequenceInput = sequenceInput.replaceAll("[^a-zA-Z]", " ");
		// this line act something like removeEmptyEntryes in C#
		sequenceInput = sequenceInput.replaceAll("  ", " ");		
		String[] sequanceArray = sequenceInput.split(" ");
		System.out.println(sequanceArray.length);
		

	}

}
