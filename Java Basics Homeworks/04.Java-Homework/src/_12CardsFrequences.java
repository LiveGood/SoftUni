import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class _12CardsFrequences {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String textInput = input.nextLine().toUpperCase();
		textInput = textInput.replaceAll("[\u2660\u2665\u2666\u2663]+", "");
		String[] splitWords = textInput.split("\\s");
		double cardslenght = splitWords.length;
		
		// linked HashMap guarantees that the keys will not be randomly ordered
		Map<String, Integer> cardsCount = new LinkedHashMap<>();
		
		for (String card : splitWords) {
			Integer count = cardsCount.get(card);
			if (count == null) {
				count = 0;
			}
			cardsCount.put(card, count+1);
		}
		
		for (String card : cardsCount.keySet()) {
			double percentage = (cardsCount.get(card) / cardslenght) * 100;
			System.out.printf("%s -> %.2f%%\n", card, percentage);
		}
		
	}

}
