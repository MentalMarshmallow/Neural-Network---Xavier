/*
 * This is each node in the input, output and hidden layers
 */
import java.util.ArrayList;
import java.util.HashMap;

public class Node {
	
	static int counter=0;// This is the id of each of the neurons that will increment each time a new neuron is created
	final public int id;
	double value;
	
	ArrayList<Connection> Connections = new ArrayList<Connection>();
	HashMap<Integer,Connection> findConnection = new HashMap<Integer,Connection>();
	
	public Node()
	{
		id=counter;
		counter++;
	}
	
}