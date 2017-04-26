/*
 * Read and Write from a file
 */
import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.PrintWriter;
import java.nio.file.DirectoryNotEmptyException;
import java.nio.file.NoSuchFileException;
import java.util.*;

public class fileIO {
	
	Scanner scanO;//Output scanner
	Scanner scanI;//Input scanner
	File LetterOutput;//Expected Letter Output file
	File LetterInput;//Inputs file for a trained network
	
	fileIO(String input,String output)
	{
		LetterOutput = new File(output);
		if(!LetterOutput.canRead())
		{
			System.out.println("Output file not found");
		}
		
		//Add the input and output scanners
		try
		{
    		scanO = new Scanner(LetterOutput);
    		
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
		//Open a new scanner to reset it
		try
		{
    		scanO = new Scanner(LetterOutput);
    		
    	}//end try
    	catch(FileNotFoundException e)
    	{
    		System.out.println("File not found.");
    		System.exit(0);
    	}
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
	
	/*
	 * Write a 2d array of pixels at the space of inputNumber
	 * Does this by reading the file and writing it to a temp file. Then adding whatever details are needed
	 * then it destroys the original file and renames the temp file to the original file
	 */
	public void writePixels(int pixels[][],String letter) throws FileNotFoundException, DirectoryNotEmptyException, NoSuchFileException, IOException
	{
		PrintWriter output=null;
		
		LetterInput=new File("data/" + letter + ".txt");
		
		try
		{
			output = new PrintWriter(LetterInput);
    		
    	}//end try
    	catch(FileNotFoundException e)
    	{
    		System.out.println("File not found.");
    		System.exit(0);
    	}
		
		//Outputs the pixels array to the text file
		for(int i=0;i<pixels[0].length;i++)
		{
			StringBuilder builder = new StringBuilder();//Making a string
			
			//Go through the array and append to a string
			for (int j : pixels[i]) 
			{
			  builder.append(j);
			}
			String text = builder.toString();
			
			output.println(text);
		}
		
		scanI.close();
		output.close();
		
	}
	
	/*
	 * Reads all pixels for every letter and places them in a 2d array.
	 * Each row is a seperate letter in the Double format
	 */
	public double[][] readPixels(int number)
	{
		int rows=60;
		int cols=number;
		double [][] pixels = new double [cols][(rows+1)*(rows+1)];
		char [] letters={'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','W','X','Y','Z'};
		
		//Go through all the letters
		for(int k=0;k<number;k++)
		{
			LetterInput=new File("data/" + letters[k] + ".txt");
			
			if(!LetterInput.canRead())
			{
				System.out.println("Input file not found");
			}
			
			
			try
			{
				scanI=new Scanner(LetterInput);
	    	}//end try
	    	catch(FileNotFoundException e)
	    	{
	    		System.out.println("File not found.");
	    		System.exit(0);
	    	}
			
			String currentLine="";
			
			int count =0;//goes through the pixels
			
			for(int i=0;i<rows;i++)
			{
				currentLine = scanI.nextLine();//get current line
				
				//go through the string
				for(int j=0;j<currentLine.length();j++)
				{
					pixels[k][count] = Character.getNumericValue(currentLine.charAt(j));//Converts the currentLine to char to double
					count++;
				}
				count++;
				
			}
			
		}//End letters
		
		
		return pixels;
	}
}
