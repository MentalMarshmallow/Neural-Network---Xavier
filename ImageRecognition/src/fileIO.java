/*
 * Read and Write from a file
 */
import java.io.File;
import java.io.FileNotFoundException;
import java.util.*;

public class fileIO {
	
	Scanner scanO;//Output scanner
	Scanner scanI;//Input scanner
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
		
		//Add the input and output scanners
		try
		{
    		scanO = new Scanner(LetterOutput);
    		scanI = new Scanner(LetterInput);
    		
    	}//end try
    	catch(FileNotFoundException e)
    	{
    		System.out.println("File not found.");
    		System.exit(0);
    	}
		
	}
	
	//Returns an array of integers from the outputLetters file at the line outputNumber
	public double[] getLine(int outputNumber)
	{
		String currentLine="";
		for(int i=0;i<outputNumber;i++)
		{
			currentLine = scanO.nextLine();
		}
		
		String line[] = currentLine.split(" ");//Splits the line up
		double[] numbers = new double[line.length];//An integer array the size of line

		for (int i = 0; i < numbers.length; i++)
		{
			numbers[i] = Double.parseDouble(line[i]);
		}
		
		return numbers;
	}
	
	//Write a 2d array of pixels at the space of inputNumber
	public void writePixels(int pixels[][],int inputNumber)
	{	
		int rows=60;
		int cols=60;
		
		
	}
}
