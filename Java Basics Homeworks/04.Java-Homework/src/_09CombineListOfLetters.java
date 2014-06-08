import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

import org.omg.CORBA.PUBLIC_MEMBER;


public class _09CombineListOfLetters {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String firstLetters = input.nextLine().replaceAll(" ","");
		String secondLetters = input.nextLine().replaceAll(" ","");
	
		ArrayList<Character> firstCharList = stringToArrayList(firstLetters);
		ArrayList<Character> secondCharList = stringToArrayList(secondLetters);
		ArrayList<Character> resultCharList = new ArrayList<>();
		
		for (Character character : firstCharList) {
			resultCharList.add(character);
		}
		
		for (Character character : secondCharList) {
			if (!firstCharList.contains(character)) {
				resultCharList.add(character);
			}
		}
		for (Character character : resultCharList) {
			System.out.print(character + " ");
			
		}
		
	}

	private static ArrayList<Character> stringToArrayList(String str) {
		ArrayList<Character> charList = new ArrayList<>();
		char[] charArray = str.toCharArray();
		for (char c : charArray) {
			charList.add(c);
		}
		return charList;
	}

}
