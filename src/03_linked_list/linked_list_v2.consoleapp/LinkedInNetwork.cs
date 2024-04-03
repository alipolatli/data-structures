public class LinkedInNetwork
{
    private LinkedList<LinkedInConnection> connections;

    public LinkedInNetwork()
    {
        connections = new LinkedList<LinkedInConnection>();
    }

    public void AddConnection(LinkedInConnection connection)
    {
        connections.AddLast(connection);
    }

    public void DisplayConnections()
    {
        Console.WriteLine("Your connections:");
        foreach (var connection in connections)
        {
            Console.WriteLine(connection);
        }
    }
}
