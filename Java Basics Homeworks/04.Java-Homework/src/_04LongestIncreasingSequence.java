import java.util.ArrayList;
import java.util.Scanner;

// Problem 4.	Longest Increasing Sequence
// Write a program to find all increasing sequences inside an array of integers.
// The integers are given in a single line, separated by a space. Print the 
// sequences in the order of their appearance in the input array, each at a 
// single line. Separate the sequence elements by a space. Find also the 
// longest increasing sequence and print it at the last line. If several 
// sequences have the same longest length, print the leftmost of them. 


public class _04LongestIncreasingSequence {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String sequenceInput = input.nextLine();
		String[] sequanceArray = sequenceInput.split(" ");
		int[] numbersArray = new int[sequanceArray.length];
		StringBuilder result = new StringBuilder();
		
		for (int i = 0; i < sequanceArray.length; i++) {
			numbersArray[i] = Integer.parseInt(sequanceArray[i]);
		}
		
		ArrayList<Integer> currentList = new ArrayList<>();
		ArrayList<Integer> longestList = new ArrayList<>();
		
		int previousNumber = numbersArray[0];
		currentList.add(previousNumber);
		longestList.add(previousNumber);
		
		for (int i = 1; i < numbersArray.length; i++) {
			int currentNumber = numbersArray[i];
			
			if (currentNumber > previousNumber) {
				currentList.add(currentNumber);
				previousNumber = currentNumber;
				
				if (currentList.size() > longestList.size()) {
					// longestList = currentList;
					longestList.clear();
					for (Integer integer : currentList) {
						longestList.add(integer);
					}
				}
			}
			else {
				for (Integer integer : currentList) {
					result.append(integer + " ");
				}
				result.append("\n");
				
				currentList.clear();
				currentList.add(currentNumber);
				previousNumber = currentNumber;
			}
		}
		
		for (Integer integer : currentList) {
			result.append(integer + " ");
		}
		result.append("\n");
		
		result.append("Longest: ");
		for (Integer integer : longestList) {
			result.append(integer  + " ");
		}
		result.append("\n");
		
		System.out.print(result);
		
		
	}

}
