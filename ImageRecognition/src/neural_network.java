/*
 * This class contains the neural network
 * 
 * What it looks like:
 * 
 * (In)---(Hidden)---(Out)
 * 
 * a1---a4---a7
 * a2---a5---a8
 * a3---a6---a9
 * .    .    .
 * .    .    .
 * .    .    .
 * ai---aj---ak
 */
import java.util.*;

public class neural_network {
	
	final boolean isTrained = false;
    final Random rand = new Random();//Random value
    final ArrayList<Node> inputLayer = new ArrayList<Node>();
    final ArrayList<Node> hiddenLayer = new ArrayList<Node>();
    final ArrayList<Node> outputLayer = new ArrayList<Node>();
    final Node bias = new Node();
    final int[] layers;

    final double epsilon = 0.00000000001;
    final double learningRate = 0.9f;//Note faster learning rate will decrease accuracy
    final double momentum = 0.7f;
    
    //inputs go here
    final double inputs[][];
    
    //corresponding outputs go here
    double expectedOutputs[][];
    double resultOutputs[][];//Set to dummy values starting off
    double output[];
    
    //Constructor for a neural_network with 3 layers
    public neural_network(int input,int hidden, int output,double [][] pixels, double[] outputs){
    	
    	inputs=pixels;
    	
    	int cols=outputs.length;
    	expectedOutputs=new double[1][cols];
    	
    	for(int i=0;i<cols-1;i++)
    	{
    		expectedOutputs[0][i]=outputs[i];
    	}
    	
    	resultOutputs=expectedOutputs;//This makes the outputs the same size
    	
    	//Change the inside of the outputs to -1 as a dummy initalize
    	for(int i=0;i<resultOutputs.length;i++)
    	{
    		for(int j=0;j<resultOutputs[0].length;j++)
    		{
    			resultOutputs[i][j]=-1;
    		}
    	}
    	
    	
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
    			for(int j=0; j<layers[i];j++)
    			{
	    			Node node = new Node();
					node.addInConnections(hiddenLayer);
					node.addBiasConnection(bias);
					outputLayer.add(node);
    			}
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
    
    //get random value
    double getRandom()
    {
    	return (rand.nextDouble() * 2 - 1);//gets value between 0 and 1
    }
    
   /**
   * There is equally many nodes in the input layer as there are input variables
   */
   public void setInput(double inputs[]) 
   {
       for (int i = 0; i < inputLayer.size(); i++) 
       {
    	   System.out.println(inputs[i]);
           inputLayer.get(i).setOutput(inputs[i]);//puts each input to an individual node
       }
   }
   
   public double[] getOutput() 
   {
       double[] outputs = new double[outputLayer.size()];
       
       for (int i = 0; i < outputLayer.size(); i++)
       {
    	   outputs[i] = outputLayer.get(i).getOutput();
       }
       return outputs;
   }
   
   /**
    * Calculate the output of the neural network based on the input The forward propagation
    */
   public void activate() 
   {
       for (Node n : hiddenLayer)
       {
    	   n.calculateOutput();
       }
       for (Node n : outputLayer)
       {
    	   n.calculateOutput();
       }
   }
   
   /**
    * train the neural network till the minError is reached or the maxSteps is exceeded
    */
   void run(int maxSteps, double minError)
   {
	   int i;
	   double error = 1;//Set to maximum Error
	   
	   for(i=0 ;i<maxSteps && error>minError; i++)
	   {
		   
		   error=0;//reset error
		   
		   for(int k=0;k<inputs.length-1;k++)//Set the inputs for the nodes
		   {
			   setInput(inputs[k]);
			   
			   activate();
			   
			   output = getOutput();
			   
			   for(double q: output)
				  System.out.println(q);
			   
			   resultOutputs[k] = output;//Puts the results of the input in the output array
			   
			   /*
			    * The error is squared to expect the exponential curve in the 
			    * resultOutputs compared to the expectedOutputs
			    */
			   for(int j=0;j<expectedOutputs[k].length;j++)//Go through the outputs
			   {
				   double err=Math.pow(output[j] - expectedOutputs[k][j], 2);//Squares the (resultOutput - expectedOutput)
				   error += err;
				   System.out.println(error);
			   }
			   
			   /*
			    * Propagate what we expected through what we actually got.
			    * This partially improves the results of the outputs
			    */
			   backPropagation(expectedOutputs[k]); 
			   
		   }
		   
	   }
	   
	   printResult();
	   
   }//end Run
   
   public void backPropagation(double expectedOutput[])
   {
	   
	   int i=0;
	   
	   /*
	    * Go through the outer layer nodes and 
	    * correct the error 
	    */
	   for(Node outN : outputLayer)
	   {
		   ArrayList<Connection> connections = outN.getAllInConnections();
		   for (Connection con : connections)
		   {
			   double ak = outN.getOutput();//Outer layer node
			   double ai = con.leftNode.getOutput();//Input layer node
			   double desiredOutput = expectedOutput[i];
			   
			   double gradient = -ak * (1-ak) * ai * (desiredOutput -ak);//The gradient at which the curve will go
			   double deltaWeight = -learningRate * gradient;//At how fast you want the network to learn. 
			   double newWeight = con.getWeight() + deltaWeight;
			   
			   con.setDeltaWeight(deltaWeight);
			   con.setWeight(newWeight + ( momentum * con.getPrevDeltaWeight() ) ); 
		   }
		   i++;
	   }
	   
	   //update weights for the hidden layer nodes
	   for(Node hidN : outputLayer)
	   {
		   ArrayList<Connection> connections = hidN.getAllInConnections();
		   for (Connection con : connections)
		   {
			   double aj = hidN.getOutput();//Hidden layer node
			   double ai = con.leftNode.getOutput();//Input layer node
			   
			   double sumKoutputs =0;//Sum of the gradient outputs of the Output layer
			   int j = 0;
			   
			   for(Node outN : outputLayer)
			   {
				   double wjk = outN.getConnection(hidN.id).getWeight();//Get the weight between this hidden layer node and the outer layer nodes
				   double desiredOutput = (double) expectedOutput[j];
				   double ak = outN.getOutput();
				   
				   j++;
				   
				   sumKoutputs = sumKoutputs + (-(desiredOutput -ak ) * ak * (1 - ak) * wjk);
			   }
			   
			   double partialDerivative = aj * (1 - aj) * ai * sumKoutputs;
			   double deltaWeight = -learningRate * partialDerivative;
			   double newWeight = con.getWeight() + deltaWeight;
			   
			   con.setDeltaWeight(deltaWeight);
			   con.setWeight(newWeight + momentum * con.getPrevDeltaWeight());
		   }
		   
	   }
	   
   }//End backPropagation
   
   void printResult()
   {
	   System.out.print("ACTUAL: ");
	   for (int p = 0; p < inputs.length-1; p++)
	   {
		   System.out.println();
		   for (int x = 0; x < layers[2]; x++) {
		       System.out.print(resultOutputs[p][x] + " ");
		   }
		   
	   }
   }
   
}//End Neural Network
