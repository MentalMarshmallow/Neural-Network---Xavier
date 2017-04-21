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
	
	void toggle(int x,int y)
	{
		System.out.println(x);
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
	}
}