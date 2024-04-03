class CustomerService
{
    private Queue<Call> callQueue;

    public CustomerService()
    {
        callQueue = new Queue<Call>();
    }

    public void EnqueueCall(Call call)
    {
        callQueue.Enqueue(call);
        Console.WriteLine($"New call added: {call.CallerName}");
    }

    public void HandleCalls()
    {
        while (callQueue.Count > 0)
        {
            Call call = callQueue.Dequeue();
            Console.WriteLine($"Call handled: {call.CallerName}");
        }
    }
}
