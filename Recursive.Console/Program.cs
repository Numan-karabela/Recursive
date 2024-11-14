
var node = new Node(8);

AddNode(node, 10);
AddNode(node, 1);
AddNode(node, 9);

void Traverse(Node rootNode)
{
    if (rootNode != null)
        return;
    Traverse(rootNode.LeftNode);
    Console.WriteLine(rootNode.Val);
    Traverse(rootNode.RightNode);
}

void AddNode(Node rootNode, int val)
{
    if (val < rootNode.Val)
    {
        if (rootNode.LeftNode is null)
        {
            rootNode.LeftNode = new Node(val);
            return;
        }
        else
        {
            AddNode(rootNode.LeftNode, val);
        }
    }
    if (val > rootNode.Val)
    {
        if (rootNode.RightNode is null)
        {
            rootNode.RightNode = new Node(val);
            return;
        }
        else
        {
            AddNode(rootNode.RightNode, val);
        }
    }

};
 
class Node
{
    public Node(int val)
    {

        Val = val;
    }
    public int Val { get; set; }
    public Node LeftNode { get; set; }
    public Node RightNode { get; set; }

}