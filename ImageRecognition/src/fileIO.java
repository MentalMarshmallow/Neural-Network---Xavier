/*
 * Read and Write from a file
 */
import java.io.File;
import java.io.FileNotFoundException;
import java.util.*;

public class fileIO {
	
	Scanner scan;
	File LetterOutput;//Expected Letter Output file
	File LetterInput;//Inputs file for a trained network
	
	fileIO(String input,String output)
	{
		LetterOutput = new File(output);
		LetterInput = new File(input);
		if(!LetterOutput.canRead())
		{
			System.out.println("Output file not found");
		}
		if(!LetterInput.canRead())
		{
			System.out.println("Input file not found");
		}
	}
	
	//Returns an array of integers for the line
	public double[] newLine(Scanner scan)
	{
		this.scan = scan;
		
		String currentLine = scan.nextLine();
		
		String line[] = currentLine.split(" ");//Splits the line up
		double[] numbers = new double[line.length];//An integer array the size of line

		for (int i = 0; i < numbers.length; i++)
		{
			numbers[i] = Double.parseDouble(line[i]);
		}
		
		return numbers;
	}
	
	public void writeLine(Scanner scan,int lineNumber)
	{
		this.scan = scan;
		
		
	}
}
