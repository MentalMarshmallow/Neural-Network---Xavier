/*
 * This is each node in the input, output and hidden layers
 */
import java.util.ArrayList;
import java.util.HashMap;

public class Node {
	
	static int counter=0;// This is the id of each of the neurons that will increment each time a new node is created
	final public int id;
	Connection biasConnection;//Connection with a bias neuron set up in the neural network class
	double bias=-1;
	double output;
	
	ArrayList<Connection> InConnections = new ArrayList<Connection>();//Input connections
	HashMap<Integer,Connection> findConnection = new HashMap<Integer,Connection>();//Find the connection based on the id of the connection
	
	public Node()
	{
		id=counter;
		counter++;
	}
	
	/*
	 * Sj = (Wij * Iij) + w0j*bias
	 * 
	 * Sigmoid for a node is the total weight for each of the weights * the total inputs from the previous
	 * layer plus the weight of the bias connection times the bias input
	 * The bias allows for the shifting of the graph in the case a 0 is needed for output
	 */
	
	public void calculateOutput()
	{
		double s = 0;//Sigmoid total for the node
		
		for(Connection con : InConnections)//Getting the total weight*output for the neuron
		{
			Node prevNode = con.getFromNode();
			double weight = con.getWeight();
			double input = prevNode.getOutput();//Get output from previous layer
			
			s = s + (weight*input);
			
		}
		
		s = s + (biasConnection.getWeight()*bias);
		
		output = sigmoid(s);
	}
	
	/*
	 *  The activation function makes the function non linear to get the desired outputs
	 */
	double sigmoid(double s)
	{
		return 1.0 / (1.0 + Math.exp(s));
	}
	
	public double getBias() {
        return bias;
    }
	
	public ArrayList<Connection> getAllInConnections(){
        return InConnections;
    }
	
    public double getOutput() {
        return output;
    }
    
    public void setOutput(double o){
        output = o;
    }
}