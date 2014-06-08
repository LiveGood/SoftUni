import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;


public class _08ExtractEmails {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String inputText = input.nextLine();
		inputText = inputText.replace(". ", " ");
		// explanation of the regular expression in the link below
		// http://www.mkyong.com/regular-expressions/how-to-validate-email-address-with-regular-expression/
		String emailPattern = "^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@"
				+ "[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$";
		Pattern pattern = Pattern.compile(emailPattern);
		String[] splitetWords = inputText.split(" ");
		
		
		for (int i = 0; i < splitetWords.length; i++) {
			Matcher matcher = pattern.matcher(splitetWords[i]);
			if (matcher.matches()) {
				System.out.println(splitetWords[i]);
				
			}
		}
		
		
	}

}
