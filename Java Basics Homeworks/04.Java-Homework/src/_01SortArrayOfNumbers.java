import java.util.Arrays;
import java.util.Scanner;

// Problem 1.	Sort Array of Numbers
// Write a program to enter a number n and n integer numbers and sort 
// and print them. Keep the numbers in array of integers: int[]. Examples:
 

public class _01SortArrayOfNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int numbersLenght = Integer.parseInt(input.nextLine());
		int[] numsArray = new int[numbersLenght];
		
		for (int i = 0; i < numsArray.length; i++) {
			System.out.printf("input %d = ", i + 1);
			System.out.println();
			numsArray[i]= Integer.parseInt(input.nextLine()); 
		}
		
		Arrays.sort(numsArray);
		
		for (int i : numsArray) {
			System.out.print(i + " ");
			
		}
		
	}

}
