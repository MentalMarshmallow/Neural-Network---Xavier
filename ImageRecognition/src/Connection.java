/*
 * This class is the connection between any two nodes
 */
public class Connection {

	double weight = 0;
	double prevDeltaWeight = 0;//for momentum
	double deltaWeight = 0;
	
	final Node leftNode;
	final Node rightNode;
	static int counter = 0;
	final public int id; //// This is the id of each of the neurons that will increment each time a new node is created
	
	public Connection(Node inN, Node outN)
	{
		leftNode = inN;//Input Layer
		rightNode = outN;//Output Layer
		id = counter;
		counter++;
	}
	
	public double getWeight() {
        return weight;
    }
 
    public void setWeight(double w) {
        weight = w;
    }
 
    public void setDeltaWeight(double w) {
        prevDeltaWeight = deltaWeight;
        deltaWeight = w;
    }
 
    public double getPrevDeltaWeight() {
        return prevDeltaWeight;
    }
 
    public Node getFromNode() {
        return leftNode;
    }
 
    public Node getToNode() {
        return rightNode;
    }
}
