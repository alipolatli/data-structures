namespace linked_list.consoleapp;

class Program
{
    static void Main(string[] args)
    {
        CustomLinkedList<int> list = new();

        list.AddFirst(1);
        list.AddLast(2);
        list.AddLast(new[] { 3, 4, 5 });
        list.AddMiddle(0);
        list.AddFirst(31);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
