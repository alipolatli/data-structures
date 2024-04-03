
class Program
{
    static void Main(string[] args)
    {
        LinkedInNetwork network = new LinkedInNetwork();

        network.AddConnection(new LinkedInConnection("Stephen Curry", "Software Developer"));
        network.AddConnection(new LinkedInConnection("Kemal Kemaloğlu", "Data Scientist"));
        network.AddConnection(new LinkedInConnection("Micheal Jordan", "DevOps Engineer"));

        network.DisplayConnections();
    }
}
