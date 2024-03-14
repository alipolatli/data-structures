namespace trie.consoleapp;

class Program
{
    static void Main(string[] args)
    {
        Trie trie = new();
        trie.Add("ali");
        trie.Add("aliye");
        trie.Add("alp");
        trie.Add("alperen");
        trie.Print();
        var c = trie.Contains("ali");
    }
}


class Trie
{
    public bool IsEndOfWord { get; set; }
    public Dictionary<char, Trie> Child { get; set; } = new();

    public void Add(string word)
    {
        Trie current = this;
        foreach (var c in word)
        {
            if (!current.Child.TryGetValue(c, out var child))
            {
                child = new Trie();
                current.Child.Add(c, child);
            }

            current = child;
        }

        current.IsEndOfWord = true;
    }

    public bool Contains(string word)
    {
        Trie current = this;

        foreach (var c in word)
        {
            if (!current.Child.TryGetValue(c, out current))
            {
                return false;
            }
        }

        return current.IsEndOfWord;
    }

    public void Print() => Print(this);

    public void Print(Trie trie)
    {
        trie ??= this;

        foreach (var entry in trie.Child)
        {
            PrintSingleNode(entry.Key, entry.Value.IsEndOfWord);
            Print(entry.Value);
        }

        static void PrintSingleNode(char word, bool isEndOfWord = false)
        {
            Console.WriteLine($"-> {word}{(isEndOfWord ? "(*)" : "")}");
        }
    }
}