import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

import processing.core.PApplet;
/**
 * @author Vimal_Jain
 *
 */
public class HandWriting extends PApplet{
	boolean temp[][];
	boolean board[][];
	int rows,cols;
	float boxsize;
	
	public void setup()
	{
		rows=60;
		cols=60;
		stroke(0,69,255);
		fill(0);
		board=new boolean[rows][cols];
		temp=new boolean[rows][cols];
		boxsize=200/rows;
		
		drawboard();
	}
	
	public void mouseDragged()
	{
		int x=pmouseX;
		int y=pmouseY;
		
		x=(int)(x/boxsize);
		y=(int)(y/boxsize);
		toggle(x,y);
	}
	
	public void mouseClicked()
	{
		int x=pmouseX;
		int y=pmouseY;
		
		x=(int)(x/boxsize);
		y=(int)(y/boxsize);
		
		toggle(x,y);
	}
	
	public void keyPressed()
	{
		if(key=='c')
		{
			for(int i=0; i<rows;i++)
			{
				for(int j=0; j<cols;j++)
				{
					board[i][j]=false;
				}
			}
		}
	}
	
	//Toggles a single tile to be green
	void toggle(int x,int y)
	{
		if(x>-1 && y>-1 && x<rows && y<cols)
		{
			board[y][x]=true;
	    }
	}
	
	public void draw()
	{
		drawboard();//draw the board
		
	}
	
	void drawboard()
	{ //make the board
		for(int i=0;i<rows;i++)// y coordinate/rows increment
		{
			for(int j=0;j<cols;j++)// x coordinate/cols increment
			{
				if(board[i][j]==true)
				{
					fill(0,255,0);
				}
	      
				rect(j*boxsize,i*boxsize,boxsize,boxsize);
				fill(0);
			}
		}
	  
	}
	
	public void settings()
	{
		size(600,600);
	}
	
	
	
	public static void main(String[] args) {
		String[] a = {"MAIN"};
        PApplet.runSketch( a, new HandWriting());
        
        Scanner scan = null;
    	try
    	{
    		String filename= "LetterOutputs.txt";	//Filename hardcoded here
    		File f = new File(filename); 			//Creates a file pointer to the file
    		scan = new Scanner(f);			//Create a scanner and point it to nothing
    		if(f.canRead())
    		{
    			System.out.println("Works");
    		}
    	}//end try
    	catch(FileNotFoundException e)
    	{
    		System.out.println("File not found.");
    		System.exit(0);
    	}
    	
    	fileIO file = new fileIO(scan);
    	double [] numbers = file.newLine();
    	for(double i:numbers)
    	System.out.println(i);
        
    	/*
        neural_network nn = new neural_network(2, 4, 1);
        int maxRuns = 50000;
        double minErrorCondition = 0.001;
        nn.run(maxRuns, minErrorCondition);
        */
	}
}