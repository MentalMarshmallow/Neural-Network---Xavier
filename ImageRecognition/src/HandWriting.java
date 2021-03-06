import java.io.IOException;

import processing.core.PApplet;
/**
 * @author Vimal_Jain
 *
 */
public class HandWriting extends PApplet{
	boolean temp[][];
	boolean board[][];
	int pixels[][];//These are the pixels used by the board converted into 1 and 0
	int rows,cols;
	float boxsize;
	fileIO file;
	
	public void setup()
	{
		int number =2;//This is the number of pixels to be read
		
		file = new fileIO("LetterInputs.txt","LetterOutputs.txt");
		
    	
		double[] numbers= file.getLine(1);
		
    	//Get a double array of output values for each letter
    	
		rows=60;
		cols=60;
		stroke(0,69,255);
		fill(0);
		board=new boolean[rows][cols];
		temp=new boolean[rows][cols];
		pixels=new int[rows][cols];
		boxsize=(width/rows)/2;
		
		double[][] pixels= file.readPixels(number);//Gets the pixels for letter A
		
		
		neural_network nn = new neural_network(number, number, number,pixels,numbers);
        int maxRuns = 50000;
        double minErrorCondition = 0.001;
        nn.run(maxRuns, minErrorCondition);
		
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
	
	//Used to clear the writing screen
	public void keyPressed()
	{
		if(key=='c')//Clears the board
		{
			for(int i=0; i<rows;i++)
			{
				for(int j=0; j<cols;j++)
				{
					board[i][j]=false;
				}
			}
		}
		else if(key=='s')//Saves the pixels of the board into an integer array
		{
			for(int i=0; i<rows;i++)
			{
				for(int j=0; j<cols;j++)
				{
					if(board[i][j])//If the board says true
					{
						pixels[i][j]=1;
					}
					else
					{
						pixels[i][j]=0;
					}
				
				}
			}
			System.out.println("Saved the board");
			
			//Write the pixels to a file
			try
			{
				file.writePixels(pixels,"Z");
			}
			catch(IOException e)
			{
				System.out.println("File not found.");
	    		System.exit(0);
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
		drawboard();//draw the writing board
		//draw
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
	}
}