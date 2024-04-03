class Program
{
    static void Main(string[] args)
    {
        CustomerService customerService = new CustomerService();

        customerService.EnqueueCall(new Call("Ayşe"));
        customerService.EnqueueCall(new Call("Fatma"));
        customerService.EnqueueCall(new Call("Hayriye"));

        customerService.HandleCalls();
    }
}
