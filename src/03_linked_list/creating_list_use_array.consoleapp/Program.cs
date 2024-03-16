namespace creating_list_use_array.consoleapp;

class Program
{
    static void Main(string[] args)
    {
        var arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        FlexibleArray<int> q = new FlexibleArray<int>();
        q.LoadFromArray(arr);

        q.AddRange(new[] { 10, 11 });

        var l = new List<int>();


        while (q.Next())
        {
            Console.Write(q.Current + " ");
        }

        q.RemoveAt(5);

        Console.WriteLine("");

        while (q.Previous())
        {
            Console.Write(q.Current + " ");
        }

        Console.ReadLine();
    }
}
