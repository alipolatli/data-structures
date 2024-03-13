namespace recursive_binary_tree.consoleapp;

class Program
{
    static void Main(string[] args)
    {
        Node node = new Node(9);
        AddNode(node, 2);
        AddNode(node, 5);
        AddNode(node, 4);
        AddNode(node, 7);
        AddNode(node, 3);
        AddNode(node, 1);
        AddNode(node, 34);
        AddNode(node, 0);

        Traverse(node);
    }

    static void Traverse(Node? node)
    {
        if (node is null)
            return;

        Traverse(node.LeftNode);
        System.Console.WriteLine(node.Value);
        Traverse(node.RightNode);
    }

    static void AddNode(Node parentNode, int value)
    {
        if (value < parentNode.Value)
            AddToLeftSubtree(parentNode, value);
        else
            AddToRightSubtree(parentNode, value);
    }

    static void AddToLeftSubtree(Node parentNode, int value)
    {
        if (parentNode.LeftNode is null)
            parentNode.LeftNode = new Node(value);
        else
            AddNode(parentNode.LeftNode, value);
    }

    static void AddToRightSubtree(Node parentNode, int value)
    {
        if (parentNode.RightNode is null)
            parentNode.RightNode = new Node(value);
        else
            AddNode(parentNode.RightNode, value);
    }

}

class Node
{
    public Node(int value)
    {
        Value = value;
    }

    public int Value { get; private set; }
    public Node? LeftNode { get; set; }
    public Node? RightNode { get; set; }
}