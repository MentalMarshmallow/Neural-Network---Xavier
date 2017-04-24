//This class contains the neural network
import java.util.*;

public class neural_network {
	
	final boolean isTrained = true;
    final Random rand = new Random();//Random value
    final ArrayList<Node> inputLayer = new ArrayList<Node>();
    final ArrayList<Node> hiddenLayer = new ArrayList<Node>();
    final ArrayList<Node> outputLayer = new ArrayList<Node>();
    final Node bias = new Node();
    final int[] layers;
    final int randomWeightMultiplier = 1;

    final double epsilon = 0.00000000001;
    final double learningRate = 0.9f;
    final double momentum = 0.7f;
    
    //inputs go here
    //final double inputs[][];
    
    //corresponding outputs go here
    //final double expectedOutputs[][];
    double resultOutputs[][];//Set to dummy values starting off
    double output[];
    
    //Constructor for a neural_network with 3 layers
    public neural_network(int input,int hidden, int output){
    	
    	this.layers = new int[] {input,hidden,output};//Number of Nodes for each layer
    	
    	/**
         * Create all nodes and connections.
         * Connections are created in the node class
         */
    	for(int i=0;i<layers.length; i++)
    	{
    		if(i==0)//input layer
    		{
    			for(int j=0;j<layers[i];j++)//Creating input layer nodes
    			{
    				Node node = new Node();
    				inputLayer.add(node);
    			}
    			
    		}
    		else if(i==1)
    		{
    			for(int j=0;j<layers[i];j++)//Creating hidden layer nodes
    			{
    				Node node = new Node();
    				node.addInConnections(inputLayer);
    				node.addBiasConnection(bias);
    				hiddenLayer.add(node);
    			}
    		}
    		else if(i==2)//Creating output layer nodes
    		{
    			Node node = new Node();
				node.addInConnections(hiddenLayer);
				node.addBiasConnection(bias);
				outputLayer.add(node);
    		}
    		else
    		{
    			System.out.println("!Error NeuralNetwork init");
    		}
    		
    		//initialize random weights
    		for (Node node : hiddenLayer) 
    		{
                ArrayList<Connection> connections = node.getAllInConnections();
                
                for (Connection conn : connections) 
                {
                    double newWeight = getRandom();
                    conn.setWeight(newWeight);
                }
            }
            for (Node node : outputLayer) {
                ArrayList<Connection> connections = node.getAllInConnections();
                
                for (Connection conn : connections) 
                {
                    double newWeight = getRandom();
                    conn.setWeight(newWeight);
                }
            }
            
            //reset id counters
            Node.counter=0;
            Connection.counter=0;
    		
    	}
    }//End neural_network constructor
    
    //get random
    double getRandom()
    {
    	return (rand.nextDouble() * 2 - 1);//gets value between 0 and 1
    }
    
}
