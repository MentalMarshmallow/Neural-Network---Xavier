/*
 * Read and Write from a file
 */
import java.util.*;

public class fileIO {
	
	Scanner scan;
	
	fileIO(Scanner scan)
	{
		this.scan=scan;
	}
	
	//Returns an array of integers for the line
	public double[] newLine()
	{
		String currentLine = scan.nextLine();
		
		String line[] = currentLine.split(" ");//Splits the line up
		double[] numbers = new double[line.length];//An integer array the size of line

		for (int i = 0; i < numbers.length; i++)
		{
			numbers[i] = Double.parseDouble(line[i]);
		}
		
		return numbers;
	}
}
