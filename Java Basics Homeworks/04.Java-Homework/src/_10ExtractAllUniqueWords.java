import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;


public class _10ExtractAllUniqueWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String textInput = input.nextLine().toLowerCase();
		textInput = textInput.replaceAll("[!.,?;:/]+", "");
		String[] splitWords = textInput.split("\\s");

		Set<String> unequeWordsSet = new TreeSet<>();
		
		for (String string : splitWords) {
			unequeWordsSet.add(string);
		}
		
//		use the commented block if you don't have Java 8 installed
		unequeWordsSet.forEach(s -> System.out.print(s+ " "));
		
//		for (String string : unequeWordsSet) {
//			System.out.println(string);
//		}
		
	}

}
