public class LinkedInConnection
{
    public string Name { get; }
    public string JobTitle { get; }

    public LinkedInConnection(string name, string jobTitle)
    {
        Name = name;
        JobTitle = jobTitle;
    }

    public override string ToString()
    {
        return $"{Name} ({JobTitle})";
    }
}
