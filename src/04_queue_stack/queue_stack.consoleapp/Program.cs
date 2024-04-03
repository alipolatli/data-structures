using System.Collections;
using System.Runtime.CompilerServices;

namespace queue_stack.consoleapp;

class Program
{
    static void Main(string[] args)
    {
        CustomQueue<int> queue = new(100);
        foreach (var item in Enumerable.Range(0, 99))
        {
            queue.Enqueue(item);
        }
        for (int i = 0; i < 75; i++)
        {
            queue.Dequeue();
        }

        CustomStack<string> stack = new();
        stack.Push("A");
        stack.Push("B");
        stack.Push("C");
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
    }
}
