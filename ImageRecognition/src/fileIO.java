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
	public void writePixels(int pixels[][],int inputNumber) throws FileNotFoundException, DirectoryNotEmptyException, NoSuchFileException, IOException
	{	
		int rows=60;
		int lineCounter=0;//Counts the position of the line
		
		File temp = new File("temp.txt");//Create a temp file 
		
		PrintWriter output=null;
		
		try
		{
			output = new PrintWriter(temp);
    		scanI = new Scanner(LetterInput);
    		
    	}//end try
    	catch(FileNotFoundException e)
    	{
    		System.out.println("File not found.");
    		System.exit(0);
    	}
		
		//Move the scanner down inputNumber*cols lines and write them to the temp file
		for(int i=0;i<(inputNumber-1)*rows;i++)
		{
			output.println(scanI.nextLine());//outputs the line in the original file
			System.out.println(lineCounter);
			lineCounter++;
		}
		
		//Outputs the pixels array to the text file
		for(int i=0;i<pixels[0].length;i++)
		{
			StringBuilder builder = new StringBuilder();
			for (int j : pixels[i]) {
			  builder.append(j);
			}
			String text = builder.toString();
			
			output.println(text);
			System.out.println(text);
			lineCounter++;
		}
		
		//Add the rest of the lines. 26 as there are 26 letters
		for(int i=lineCounter;i<rows*1;i++)
		{
			output.println(scanI.nextLine());
		}
		
		LetterInput=temp;
		
		if(LetterInput.delete())//Delete the original file
		{
			temp.renameTo(LetterInput);//Rename the temp file to the original file name
			LetterInput=temp;//add temp as the new Input file
		}
		else
		{
			System.out.println(temp);
		}
		
		
		output.close();
		
	}
}
